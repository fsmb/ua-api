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
    /// 5th Pathway information
    /// </summary>
    public partial class FifthPathway
    {
        /// <summary>
        /// Initializes a new instance of the FifthPathway class.
        /// </summary>
        public FifthPathway() { }

        /// <summary>
        /// Initializes a new instance of the FifthPathway class.
        /// </summary>
        public FifthPathway(FifthPathwaySchool school, DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), DateTime? certificateDate = default(DateTime?))
        {
            School = school;
            StartDate = startDate;
            EndDate = endDate;
            CertificateDate = certificateDate;
        }

        /// <summary>
        /// School
        /// </summary>
        [JsonProperty(PropertyName = "school")]
        public FifthPathwaySchool School { get; set; }

        /// <summary>
        /// Start date
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End date
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Certification date
        /// </summary>
        [JsonProperty(PropertyName = "certificateDate")]
        public DateTime? CertificateDate { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (School == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "School");
            }
            if (this.School != null)
            {
                this.School.Validate();
            }
        }
    }
}
