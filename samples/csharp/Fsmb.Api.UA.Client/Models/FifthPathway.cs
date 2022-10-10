﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fsmb.Api.Ua.Client.Models
{
    /// <summary>
    /// 5th Pathway information
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class FifthPathway
    {        
        /// <summary>
        /// School
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "school", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public FifthPathwaySchool School { get; set; }

        /// <summary>
        /// Start date
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startDate", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTime StartDate { get; set; }

        /// <summary>
        /// End date
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endDate", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTime EndDate { get; set; }

        /// <summary>
        /// Certification date
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "certificateDate", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTime CertificateDate { get; set; }
    }
}