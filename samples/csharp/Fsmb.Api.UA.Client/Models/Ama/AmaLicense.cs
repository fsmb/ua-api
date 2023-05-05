﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fsmb.Api.Ua.Client.Models
{
    /// <summary>
    /// State medical license information.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AmaLicense
    {
        /// <summary>License number.</summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "licenseNumber", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
        public string LicenseNumber { get; set; }

        /// <summary>Issue date.</summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "issueDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? IssueDate { get; set; }

        /// <summary>Expiration date.</summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "expirationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? ExpirationDate { get; set; }

        /// <summary>Last reported date.</summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastReportedDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? LastReportedDate { get; set; }

        /// <summary>Type of license (e.g. 'Limited', 'Pending', 'Restricted', 'Temporary', 'Unlimited').</summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TypeDescription { get; set; }

        /// <summary>State issuing the license.</summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "stateDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StateDescription { get; set; }

        /// <summary>Licensing degree code (e.g. 'MD', 'DO').</summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "degreeCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DegreeCode { get; set; }

        /// <summary>Status of license (e.g. 'Active', 'Inactive', 'Denied', 'Unknown').</summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "licenseStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LicenseStatus { get; set; }

        /// <summary>Renewal date.</summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "renewalDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? RenewalDate { get; set; }

        /// <summary>Physician name.</summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "physicianName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AmaName PhysicianName { get; set; }
    }
}
