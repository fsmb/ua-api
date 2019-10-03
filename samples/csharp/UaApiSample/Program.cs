/*
 * Copyright © 2019 Federation of State Medical Boards
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
 * documentation files (the “Software”), to deal in the Software without restriction, including without limitation the
 * rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit
 * persons to whom the Software is furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
 * COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
using System;
using System.Net.Http;
using System.Threading.Tasks;

using Fsmb.Apis.Authentication;
using Fsmb.Apis.Ua.Clients;

using Microsoft.Rest;

namespace Fsmb.Apis.UA.Sample
{
    class Program
    {        
        static void Main ( string[] args )
        {
            var program = new Program();

            program.Run(args);
        }                                                    

        #region Client Calls

        // Gets a submission by its ID
        private async Task GetSubmissionByIdAsync ( UaClient client, int id )
        {
            //Call API
            Terminal.WriteDebug($"Getting submission by Id {id}");
            var result = await client.Submissions.GetByIdAsync("me", id).ConfigureAwait(false);
            if (result == null)
                Terminal.WriteWarning("No submission found");
            else
                WriteSubmission(result);
        }

        // Gets a summary of the submissions in a given date range
        private async Task GetSummaryByDateRangeAsync ( UaClient client, DateTime beginDate, DateTime endDate )
        {
            //Call API
            Terminal.WriteDebug($"Getting summary submissions between '{beginDate.ToString("MM/dd/yyyy")}' and '{endDate.ToString("MM/dd/yyyy")}'");
            var results = await client.Submissions.GetSummaryAsync("me", fromDate: beginDate, toDate: endDate).ConfigureAwait(false);

            foreach (var result in results)
            {
                Terminal.WriteLine($"ID = {result.Id}");
                Terminal.WriteLine($"Name = {GetFullName(result.Name)}");
                Terminal.WriteLine($"FID = {result.Fid}");
                Terminal.WriteLine($"Submit Date = {result.SubmitDate}");
                Terminal.WriteLine();
            };
        }        

        private static string GetFullName ( Ua.Clients.Models.Name name ) 
                        => String.Join(" ", name.FirstName, name.MiddleName, name.LastName, name.Suffix);

        private void WriteSubmission ( Ua.Clients.Models.Submission submission )
        {
            Terminal.WriteLine($"ID = {submission.Id}");

            var legalName = submission.Names.LegalName;            
            Terminal.WriteLine($"Name = {GetFullName(legalName)}");

            Terminal.WriteLine($"FID = {submission.Fid}");
            Terminal.WriteLine($"Submit Date = {submission.SubmitDate}");
        }
        #endregion

        #region Private Members        

        private Func<UaClient, Task> DisplayMenu ( )
        {
            Terminal.WriteLine("\nUA API Options");
            Terminal.WriteLine("".PadLeft(20, '-'));
                        
            Terminal.WriteLine("1) Get a summary of submissions in a date range");
            Terminal.WriteLine("2) Get a submission by ID");
            Terminal.WriteLine("3) Get the submissions for a specific FID");
            Terminal.WriteLine("0) Quit");

            do
            {
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '0': return OnQuitAsync;
                    case '1': return OnSummaryByDateAsync;
                    case '2': return OnSubmissionByIdAsync;
                };                
            } while (true);
        }

        private async Task<ServiceClientCredentials> GetCredentialsAsync ( ProgramOptions options )
        {
            //Create a single instance of HttpClient per base address per application otherwise you can run out of resources
            var httpClient = new HttpClient() { BaseAddress = new Uri(options.AuthenticationUrl) };

            var client = new AuthenticationClient(httpClient);

            Terminal.WriteDebug("Authenticating user");
            var accessToken = await client.AuthenticateAsync(options.ClientId, options.ClientSecret, "ua.read").ConfigureAwait(false);

            return new TokenCredentials(accessToken);            
        }

        private bool Initialize ( string[] args )
        {
            var options = ParseCommandLine(args);
            if (options == null)
            {
                ShowHelp();
                return false;
            };

            //Verify required values are set            
            if (String.IsNullOrEmpty(options.ClientId))
                options.ClientId = Terminal.ReadString("Client Id? ", allowEmptyStrings: false);

            if (String.IsNullOrEmpty(options.ClientSecret))
                options.ClientSecret = Terminal.ReadString("Client Secret? ", allowEmptyStrings: false);

            _options = options;
            return true;
        }

        private Task OnQuitAsync ( UaClient client )
        {
            _quit = true;

            return Task.CompletedTask;
        }

        private async Task OnSubmissionByIdAsync ( UaClient client )
        {
            try
            {
                //Get the ID
                var id = Terminal.ReadInt32("Submission ID (or ENTER to cancel)? ", minValue: 1);
                if (!id.HasValue)
                    return;

                await GetSubmissionByIdAsync(client, id.Value).ConfigureAwait(false);
            } catch (Exception e)
            {
                e = e.Unwrap();

                Terminal.WriteError(e.Message);
            };
        }

        private async Task OnSummaryByDateAsync ( UaClient client )
        {
            try
            {
                //Get date range
                var beginDate = Terminal.ReadDate("Begin date (or ENTER to cancel)? ", allowEmpty: true);
                if (!beginDate.HasValue)
                    return;

                var endDate = Terminal.ReadDate("End date (or ENTER for today)? ", minDate: beginDate.Value, allowEmpty: true);
                if (!endDate.HasValue)
                    endDate = DateTime.Now;

                await GetSummaryByDateRangeAsync(client, beginDate.Value, endDate.Value).ConfigureAwait(false);
            } catch (Exception e)
            {
                e = e.Unwrap();

                Terminal.WriteError(e.Message);
            };
        }

        private ProgramOptions ParseCommandLine ( string[] args )
        {
            var options = new ProgramOptions();

            Action<string> argumentAction = null;
            foreach (var arg in args)
            {
                var isSwitch = arg.StartsWithAny('-', '/');
                var argument = (isSwitch ? arg.Trim('-', '/').ToLower() : arg).Trim();

                var badArgument = false;

                if (isSwitch)
                {
                    switch (argument)
                    {
                        case "clientid": argumentAction = value => options.ClientId = value; break;
                        case "clientsecret": argumentAction = value => options.ClientSecret = value; break;
                        case "url": argumentAction = value => options.BaseAddress = value; break;
                        case "help": return null;

                        default: badArgument = true; break;
                    };
                } else if (argumentAction != null)
                {
                    argumentAction(arg);
                    argumentAction = null;
                } else
                    badArgument = true;

                if (badArgument)
                {
                    Terminal.WriteError($"Unknown argument '{arg}'");
                    return null;
                };
            };

            if (argumentAction != null)
            {
                Terminal.WriteError("No argument specified");
                return null;
            };            

            return options;
        }

        private void Run ( string[] args )
        {
            try
            {
                if (!Initialize(args))
                    return;

                RunAsync().Wait();
            } catch (Exception e)
            {
                e = e.Unwrap();

                Terminal.WriteError(e.Message);
                 throw;
            };            
        }

        private async Task RunAsync ()
        {         
            //Authenticate the client
            var credentials = await GetCredentialsAsync(_options).ConfigureAwait(false);

            //Create the client 
            var client = new UaClient(new Uri(_options.ApiUrl), credentials);

            do
            {
                var handler = DisplayMenu();
                await handler(client);
            } while (!_quit);
        }

        private void ShowHelp ()
        {
            Terminal.WriteLine("-clientId {id} where {id} is the client ID");
            Terminal.WriteLine("-clientSecret {secret} where {secret} is the client secret");
            Terminal.WriteLine("-url {url} where {url} is the base URL (default is https://demo-services.fsmb.org)");
        }        

        private bool _quit;
        private ProgramOptions _options;
        #endregion
    }
}
