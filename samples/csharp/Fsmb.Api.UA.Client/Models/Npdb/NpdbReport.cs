﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
namespace Fsmb.Api.Ua.Client.Models
{
    /// <summary>
    /// NPDB report, if available
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class NpdbReport
    {
        /// <summary>Date the report was generated.</summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "asOfDate", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTime AsOfDate { get; set; }

        /// <summary>List of available reports, if any</summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "availableReports", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IList<NpdbReportType> AvailableReports { get; set; }

        /// <summary>Are reports available?</summary>
        [Newtonsoft.Json.JsonProperty("hasAvailableReports", Required = Newtonsoft.Json.Required.Always)]
        public bool HasAvailableReports { get; set; }        
    }
}