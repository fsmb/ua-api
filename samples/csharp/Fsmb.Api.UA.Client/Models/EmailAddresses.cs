﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fsmb.Api.Ua.Client.Models
{
    /// <summary>
    /// Email information
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EmailAddresses
    {
        /// <summary>
        /// Public email
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "forPublic", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public EmailAddress ForPublic { get; set; }

        /// <summary>
        /// Board email
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "forBoard", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public EmailAddress ForBoard { get; set; }

        /// <summary>
        /// Other emails
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "other", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IList<EmailAddress> Other { get; set; }
    }
}
