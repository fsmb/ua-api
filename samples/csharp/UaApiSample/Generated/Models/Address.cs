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
    /// Mailing address
    /// </summary>
    public partial class Address
    {
        /// <summary>
        /// Initializes a new instance of the Address class.
        /// </summary>
        public Address() { }

        /// <summary>
        /// Initializes a new instance of the Address class.
        /// </summary>
        public Address(string addressType, string city, Region stateOrProvince, string postalCode, IList<string> lines = default(IList<string>))
        {
            AddressType = addressType;
            Lines = lines;
            City = city;
            StateOrProvince = stateOrProvince;
            PostalCode = postalCode;
        }

        /// <summary>
        /// Type of address (e.g. Business, Home)
        /// </summary>
        [JsonProperty(PropertyName = "addressType")]
        public string AddressType { get; set; }

        /// <summary>
        /// Address lines
        /// </summary>
        [JsonProperty(PropertyName = "lines")]
        public IList<string> Lines { get; set; }

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
        /// Postal code
        /// </summary>
        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (AddressType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AddressType");
            }
            if (City == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "City");
            }
            if (StateOrProvince == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StateOrProvince");
            }
            if (PostalCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PostalCode");
            }
            if (this.StateOrProvince != null)
            {
                this.StateOrProvince.Validate();
            }
        }
    }
}
