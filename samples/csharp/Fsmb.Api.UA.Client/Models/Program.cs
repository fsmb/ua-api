﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fsmb.Api.Ua.Client.Models
{
    /// <summary>
    /// Postgraduate training program
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Program
    {        
        /// <summary>
        /// Hospital name
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "hospitalName", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        public string HospitalName { get; set; }

        /// <summary>
        /// Affiliated institution
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "affiliatedInstitution", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AffiliatedInstitution { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "city", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        public string City { get; set; }

        /// <summary>
        /// State/province
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "stateOrProvince", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public StateOrProvince StateOrProvince { get; set; }
    }
}
