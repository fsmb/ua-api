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
    /// Phone number
    /// </summary>
    public partial class Phone
    {
        /// <summary>
        /// Initializes a new instance of the Phone class.
        /// </summary>
        public Phone() { }

        /// <summary>
        /// Initializes a new instance of the Phone class.
        /// </summary>
        public Phone(string phoneType, string phoneNumber, string extension = default(string))
        {
            PhoneType = phoneType;
            PhoneNumber = phoneNumber;
            Extension = extension;
        }

        /// <summary>
        /// Type of phone (Business, Home, Mobile)
        /// </summary>
        [JsonProperty(PropertyName = "phoneType")]
        public string PhoneType { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Phone extension
        /// </summary>
        [JsonProperty(PropertyName = "extension")]
        public string Extension { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (PhoneType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PhoneType");
            }
            if (PhoneNumber == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PhoneNumber");
            }
        }
    }
}
