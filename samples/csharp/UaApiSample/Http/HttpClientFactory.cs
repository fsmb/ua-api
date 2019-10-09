/*
 * Copyright © 2018 Federation of State Medical Boards
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
using System.Net.Http;

namespace Fsmb.Apis.UA.Http
{
    /// <summary>Simple factory for creating <see cref="HttpClient" /> instances.</summary>
    /// <remarks>
    /// As discussed <see href="https://blogs.msdn.microsoft.com/shacorn/2016/10/21/best-practices-for-using-httpclient-on-services/ ">here</see>, clients should be created once (per base address) and reused for the life of the application.
    /// </remarks>
    public class HttpClientFactory
    {
        /// <summary>Gets a client given its name.</summary>
        /// <param name="name">The name of the client.</param>        
        /// <returns>The client.</returns>
        public HttpClient GetClient ( string name )
        {
            //Validate
            if (String.IsNullOrEmpty(name))
                throw new ArgumentException("Name cannot be empty.", nameof(name));

            //Try and get the client
            if (!_clients.TryGetValue(name, out var info))
                throw new ArgumentException("Client not registered.");

            //Initialize the client if needed
            if (info.Client == null)
            {
                //Make this thread safe as generally there should be a single instance
                lock(info)
                {
                    if (info.Client == null)
                        InitializeClient(info);
                };                
            };

            return info.Client;
        }

        /// <summary>Registers a client with the factory.</summary>
        /// <param name="name">The name of the client.</param>
        /// <param name="url">The base address to use.</param>
        /// <returns>The factory.</returns>
        public HttpClientFactory RegisterClient ( string name, string url )
        {
            //Validate
            if (String.IsNullOrEmpty(url))
                throw new ArgumentException("Url cannot be empty.", nameof(url));

            //URLs must end with a slash otherwise path building doesn't work
            if (!url.EndsWith("/"))
                url += "/";
            
            return RegisterClient(name, new Uri(url, UriKind.Absolute));
        }

        /// <summary>Registers a client with the factory.</summary>
        /// <param name="name">The name of the client.</param>
        /// <param name="url">The base address to use.</param>
        /// <returns>The factory.</returns>
        public HttpClientFactory RegisterClient ( string name, Uri url )
        {
            //Validate
            if (String.IsNullOrEmpty(name))
                throw new ArgumentException("Name cannot be empty.", nameof(name));
            if (url == null)
                throw new ArgumentNullException(nameof(url));
            
            //Add the client info to the list
            var info = new ClientInfo() {
                BaseAddress = url
            };

            _clients[name] = info;

            return this;
        }       

        #region Private Members

        private sealed class ClientInfo
        {
            public Uri BaseAddress { get; set; }

            public HttpClient Client { get; set; }
        }

        private void InitializeClient ( ClientInfo info )
        {
            info.Client = new HttpClient() { BaseAddress = info.BaseAddress };
        }

        private readonly Dictionary<string, ClientInfo> _clients = new Dictionary<string, ClientInfo>();
        #endregion
    }
}
