﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fsmb.Api.Ua.Client.Models
{
    /// <summary>
    /// A submission
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Submission
    {        
        /// <summary>
        /// Submission ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id", Required = Newtonsoft.Json.Required.Always)]        
        public long Id { get; set; }

        /// <summary>
        /// FID of practitioner
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fid", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        public string Fid { get; set; }

        /// <summary>
        /// Date/time of submission
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "submitDate", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTime SubmitDate { get; set; }

        /// <summary>
        /// Application information
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "application", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Application Application { get; set; }

        /// <summary>
        /// Identity information
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "identity", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Identification Identity { get; set; }

        /// <summary>
        /// Names
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "names", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Names Names { get; set; }

        /// <summary>
        /// Mailing addresses
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "addresses", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public MailingAddresses Addresses { get; set; }

        /// <summary>
        /// Email addresses
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "emailAddresses", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public EmailAddresses EmailAddresses { get; set; }

        /// <summary>
        /// Phone numbers
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "phones", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Phones Phones { get; set; }

        /// <summary>
        /// Medical education
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "medicalEducation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MedicalEducationTraining MedicalEducation { get; set; }

        /// <summary>
        /// Postgraduate training
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "postGraduateTraining", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PostGraduateTraining PostGraduateTraining { get; set; }

        /// <summary>
        /// Exams
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "exams", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IList<Exam> Exams { get; set; }

        /// <summary>
        /// Licenses
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "licenses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IList<License> Licenses { get; set; }

        /// <summary>
        /// Malpractice information
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "malpractice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IList<Malpractice> Malpractice { get; set; }

        /// <summary>
        /// Chronology of activity
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "activities", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IList<Activity> Activities { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "addendum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Addendum { get; set; }

        /// <summary>
        /// Status of PDC report. Refer to ReportStatus for possible values.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "pdcReportStatus", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        public string PdcReportStatus { get; set; }

        /// <summary>PDC information, if available.</summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "pdc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PdcReport Pdc { get; set; }
    }
}
