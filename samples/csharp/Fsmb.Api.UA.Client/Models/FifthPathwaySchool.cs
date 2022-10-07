﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fsmb.Api.Ua.Client.Models
{
    /// <summary>
    /// 5th Pathway school information
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class FifthPathwaySchool
    {       
        /// <summary>
        /// School name
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        /// <summary>
        /// Affiliated institution
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "affiliatedInstitution", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        public string AffiliatedInstitution { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// State/province
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "stateOrProvince", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Region StateOrProvince { get; set; }
    }
}
