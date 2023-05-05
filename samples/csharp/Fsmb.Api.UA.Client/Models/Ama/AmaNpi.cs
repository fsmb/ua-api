﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fsmb.Api.Ua.Client.Models
{
    /// <summary>
    /// NPI information.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AmaNpi
    {
        /// <summary>NPI number.</summary>        
        [Newtonsoft.Json.JsonProperty(PropertyName = "npiNumber", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        public string NpiNumber { get; set; }

        /// <summary>Date the number was deactivated.</summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "deactivationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? DeactivationDate { get; set; }

        /// <summary>Date the number was reactivated.</summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "reactivationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? ReactivationDate { get; set; }

        /// <summary>Replacement NPI number.</summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "replacementNpiNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReplacementNpiNumber { get; set; }

        /// <summary>Last reported date.</summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastReportedDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? LastReportedDate { get; set; }

        /// <summary>End date.</summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? EndDate { get; set; }
    }
}