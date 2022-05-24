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

    public partial class LicenseSubtype
    {
        /// <summary>
        /// Initializes a new instance of the LicenseSubtype class.
        /// </summary>
        public LicenseSubtype() { }

        /// <summary>
        /// Initializes a new instance of the LicenseSubtype class.
        /// </summary>
        public LicenseSubtype(string code = default(string), string description = default(string))
        {
            Code = code;
            Description = description;
        }

        /// <summary>
        /// Code
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Description of license (e.g. Permanent Medical License
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}