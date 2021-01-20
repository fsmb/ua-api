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
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using Fsmb.Apis.Ua.Clients;

using Microsoft.Rest;

namespace Fsmb.Apis.UA.Sample
{
    class Program
    {        
        public Program ()
        {
            _client = new Lazy<UaClient>(CreateClient);
        }

        static void Main ( string[] args )
        {
            var program = new Program();

            program.Run(args);
        }

        #region API Calls

        private UaClient CreateClient ()
            => new UaClient(new Uri(_options.BaseAddress), _options.ClientId, _options.ClientSecret);

        // Gets submissions by a FID
        private async Task GetSubmissionByFidAsync ( UaClient client, string fid )
        {
            //Call API
            Terminal.WriteDebug($"Getting submissions for FID {fid}");
            var submissions = await client.Submissions.GetByRequestAsync("me", fid: fid).ConfigureAwait(false);
            if (!(submissions?.Any() ?? false))
                Terminal.WriteWarning("No submissions found");
            else
            {
                foreach (var submission in submissions)
                {
                    WriteSubmission(submission);
                    Terminal.WriteLine();
                };
            };
        }

        // Gets latest submissions by a FID
        private async Task GetLatestSubmissionByFidAsync(UaClient client, string fid)
        {
            //Call API
            Terminal.WriteDebug($"Getting latest submissions for FID {fid}");
            var submission = await client.Practitioners.GetLatestAsync("me", fid: fid).ConfigureAwait(false);
            if (submission == null)
                Terminal.WriteWarning("No submission found");
            else
            {
                WriteSubmission(submission);
                Terminal.WriteLine();
            };
        }

        // Gets a submission by its ID
        private async Task GetSubmissionByIdAsync ( UaClient client, int id )
        {
            //Call API
            Terminal.WriteDebug($"Getting submission by Id {id}");
            var submission = await client.Submissions.GetByIdAsync("me", id).ConfigureAwait(false);
            if (submission == null)
                Terminal.WriteWarning("No submission found");
            else
                WriteSubmission(submission);
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
                        
            Terminal.WriteLine("1) Get the latest submissions for a specific FID");
            Terminal.WriteLine("2) Get a summary of submissions in a date range");
            Terminal.WriteLine("3) Get a submission by ID");
            Terminal.WriteLine("4) Get the submissions for a specific FID");
            Terminal.WriteLine("0) Quit");

            do
            {
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '0': return OnQuitAsync;
                    case '1': return OnLatestSubmissionByFidAsync;
                    case '2': return OnSummaryByDateAsync;
                    case '3': return OnSubmissionByIdAsync;
                    case '4': return OnSubmissionByFidAsync;
                };                
            } while (true);
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

        private async Task OnLatestSubmissionByFidAsync(UaClient client)
        {
            try
            {
                //Get the FID
                var fid = Terminal.ReadString("FID (or ENTER to cancel)? ", allowEmptyStrings: true);
                if (String.IsNullOrEmpty(fid))
                    return;

                await GetLatestSubmissionByFidAsync(client, fid).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                e = e.Unwrap();

                Terminal.WriteError(e.Message);
            };
        }

        private async Task OnSubmissionByFidAsync ( UaClient client )
        {
            try
            {
                //Get the FID
                var fid = Terminal.ReadString("FID (or ENTER to cancel)? ", allowEmptyStrings: true);
                if (String.IsNullOrEmpty(fid))
                    return;

                await GetSubmissionByFidAsync(client, fid).ConfigureAwait(false);
            } catch (Exception e)
            {
                e = e.Unwrap();

                Terminal.WriteError(e.Message);
            };
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
            do
            {
                var handler = DisplayMenu();
                await handler(Client);
            } while (!_quit);
        }

        private void ShowHelp ()
        {
            Terminal.WriteLine("-clientId {id} where {id} is the client ID");
            Terminal.WriteLine("-clientSecret {secret} where {secret} is the client secret");
            Terminal.WriteLine("-url {url} where {url} is the base URL (default is https://demo-services.fsmb.org)");
        }

        private readonly Lazy<UaClient> _client;

        private UaClient Client => _client.Value;

        private bool _quit;
        private ProgramOptions _options;        
        #endregion
    }
}
