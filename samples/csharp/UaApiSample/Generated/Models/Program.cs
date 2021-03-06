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
    /// Postgraduate training program
    /// </summary>
    public partial class Program
    {
        /// <summary>
        /// Initializes a new instance of the Program class.
        /// </summary>
        public Program() { }

        /// <summary>
        /// Initializes a new instance of the Program class.
        /// </summary>
        public Program(string hospitalName, string city, Region stateOrProvince, string affiliatedInstitution = default(string))
        {
            HospitalName = hospitalName;
            AffiliatedInstitution = affiliatedInstitution;
            City = city;
            StateOrProvince = stateOrProvince;
        }

        /// <summary>
        /// Hospital name
        /// </summary>
        [JsonProperty(PropertyName = "hospitalName")]
        public string HospitalName { get; set; }

        /// <summary>
        /// Affiliated institution
        /// </summary>
        [JsonProperty(PropertyName = "affiliatedInstitution")]
        public string AffiliatedInstitution { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// State/province
        /// </summary>
        [JsonProperty(PropertyName = "stateOrProvince")]
        public Region StateOrProvince { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (HospitalName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HospitalName");
            }
            if (City == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "City");
            }
            if (StateOrProvince == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StateOrProvince");
            }
            if (this.StateOrProvince != null)
            {
                this.StateOrProvince.Validate();
            }
        }
    }
}
