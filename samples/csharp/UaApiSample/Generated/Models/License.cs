﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fsmb.Apis.Ua.Clients.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// License information
    /// </summary>
    public partial class License
    {
        /// <summary>
        /// Initializes a new instance of the License class.
        /// </summary>
        public License() { }

        /// <summary>
        /// Initializes a new instance of the License class.
        /// </summary>
        public License(string licenseType = default(string), CodedDescription licensingEntity = default(CodedDescription), string status = default(string), CodedDescription practitionerType = default(CodedDescription), string licenseNumber = default(string), DateTime? issueDate = default(DateTime?), DateTime? expirationDate = default(DateTime?))
        {
            LicenseType = licenseType;
            LicensingEntity = licensingEntity;
            Status = status;
            PractitionerType = practitionerType;
            LicenseNumber = licenseNumber;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
        }

        /// <summary>
        /// Type of license
        /// </summary>
        [JsonProperty(PropertyName = "licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Entity issuing license
        /// </summary>
        [JsonProperty(PropertyName = "licensingEntity")]
        public CodedDescription LicensingEntity { get; set; }

        /// <summary>
        /// License status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Practitioner type
        /// </summary>
        [JsonProperty(PropertyName = "practitionerType")]
        public CodedDescription PractitionerType { get; set; }

        /// <summary>
        /// License number
        /// </summary>
        [JsonProperty(PropertyName = "licenseNumber")]
        public string LicenseNumber { get; set; }

        /// <summary>
        /// Issue date
        /// </summary>
        [JsonProperty(PropertyName = "issueDate")]
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// Expiration date
        /// </summary>
        [JsonProperty(PropertyName = "expirationDate")]
        public DateTime? ExpirationDate { get; set; }

    }
}