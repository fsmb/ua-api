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
    /// Application information
    /// </summary>
    public partial class Application
    {
        /// <summary>
        /// Initializes a new instance of the Application class.
        /// </summary>
        public Application() { }

        /// <summary>
        /// Initializes a new instance of the Application class.
        /// </summary>
        public Application(string licenseType, string boardName, LicenseSubtype licenseSubtypeDetails)
        {
            LicenseType = licenseType;
            BoardName = boardName;
            LicenseSubtypeDetails = licenseSubtypeDetails;
        }

        /// <summary>
        /// Type of license - MD, DO, PA
        /// </summary>
        [JsonProperty(PropertyName = "licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Board name
        /// </summary>
        [JsonProperty(PropertyName = "boardName")]
        public string BoardName { get; set; }

        /// <summary>
        /// Subtype of license
        /// </summary>
        [JsonProperty(PropertyName = "licenseSubtypeDetails")]
        public LicenseSubtype LicenseSubtypeDetails { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (LicenseType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LicenseType");
            }
            if (BoardName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BoardName");
            }
            if (LicenseSubtypeDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LicenseSubtypeDetails");
            }
        }
    }
}