﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fsmb.Api.Ua.Client
{
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial interface IUaClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        Microsoft.Rest.ServiceClientCredentials Credentials { get; }
        
        /// <summary>
        /// Gets the IPractitioners.
        /// </summary>
        IPractitioners Practitioners { get; }

        /// <summary>
        /// Gets the ISubmissions.
        /// </summary>
        ISubmissions Submissions { get; }

    }
}
