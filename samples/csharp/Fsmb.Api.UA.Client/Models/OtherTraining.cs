﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fsmb.Api.Ua.Client.Models
{
    /// <summary>
    /// Non-accredited postgraduate training
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class OtherTraining
    {        
        /// <summary>
        /// Program
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "program", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Program Program { get; set; }

        /// <summary>
        /// Specialty
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "specialty", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Specialty Specialty { get; set; }

        /// <summary>
        /// Program type
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "programType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        public string ProgramType { get; set; }

        /// <summary>
        /// Training status
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "trainingStatus", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        public string TrainingStatus { get; set; }

        /// <summary>
        /// Start date
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "beginDate", Required = Newtonsoft.Json.Required.Always)]        
        public System.DateTime BeginDate { get; set; }

        /// <summary>
        /// End date
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endDate", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTime EndDate { get; set; }

        /// <summary>
        /// Percentage of training that was Clinical
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "percentageClinical", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PercentageClinical { get; set; }

        /// <summary>
        /// Percentage of training that was Administrative
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "percentageAdministrative", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PercentageAdministrative { get; set; }
    }
}
