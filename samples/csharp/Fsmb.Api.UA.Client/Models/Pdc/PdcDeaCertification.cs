﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fsmb.Api.Ua.Client.Models
{
    /// <summary>PDC DEA certificate</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PdcDeaCertification
    {
        /// <summary>Report date</summary>
        [Newtonsoft.Json.JsonProperty("reportDate", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTime ReportDate { get; set; }

        /// <summary>DEA number</summary>
        [Newtonsoft.Json.JsonProperty("deaNumber", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        public string DeaNumber { get; set; }

        /// <summary>Expiration date</summary>
        [Newtonsoft.Json.JsonProperty("expirationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? ExpirationDate { get; set; }

        /// <summary>Drug schedules (space separated)</summary>
        [Newtonsoft.Json.JsonProperty("drugSchedules", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DrugSchedules { get; set; }

        /// <summary>City</summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>State</summary>
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>Zip code</summary>
        [Newtonsoft.Json.JsonProperty("zipCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZipCode { get; set; }
    }
}