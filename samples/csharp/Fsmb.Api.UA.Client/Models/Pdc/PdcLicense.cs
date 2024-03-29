﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fsmb.Api.Ua.Client.Models
{
    /// <summary>PDC license</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PdcLicense
    {
        /// <summary>Report date</summary>
        [Newtonsoft.Json.JsonProperty("reportDate", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTime ReportDate { get; set; }

        /// <summary>Type of license</summary>
        [Newtonsoft.Json.JsonProperty("licenseType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LicenseType { get; set; }

        /// <summary>Issuer of license</summary>
        [Newtonsoft.Json.JsonProperty("issuer", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public LicensingEntity Issuer { get; set; }

        /// <summary>License status</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>License number</summary>
        [Newtonsoft.Json.JsonProperty("licenseNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LicenseNumber { get; set; }

        /// <summary>Issue date</summary>
        [Newtonsoft.Json.JsonProperty("issueDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? IssueDate { get; set; }

        /// <summary>Expiration date</summary>
        [Newtonsoft.Json.JsonProperty("expirationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? ExpirationDate { get; set; }


    }
}