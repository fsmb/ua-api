﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fsmb.Api.Ua.Client.Models
{

    /// <summary>FCVS profile report.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class FcvsProfileReport
    {
        /// <summary>
        /// Profile ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "profileId", Required = Newtonsoft.Json.Required.Always)]
        public long ProfileId { get; set; }

        /// <summary>Profile status</summary>
        [Newtonsoft.Json.JsonProperty("profileStatus", Required = Newtonsoft.Json.Required.Always)]
        public string ProfileStatus { get; set; }

        /// <summary>Date/time the profile was submitted (in UTC)</summary>
        [Newtonsoft.Json.JsonProperty("profileSubmitDateUtc", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTime ProfileSubmitDateUtc { get; set; }

        /// <summary>Determines if the profile has been sent</summary>
        [Newtonsoft.Json.JsonProperty("hasBeenSent", Required = Newtonsoft.Json.Required.Always)]
        public bool HasBeenSent { get; set; }

        /// <summary>Date/time the profile was sent (in UTC), if any</summary>
        [Newtonsoft.Json.JsonProperty("profileSentDateUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? ProfileSentDateUtc { get; set; }
    }
}