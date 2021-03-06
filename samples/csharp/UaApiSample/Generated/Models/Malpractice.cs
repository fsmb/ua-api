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
    /// Malpractice information
    /// </summary>
    public partial class Malpractice
    {
        /// <summary>
        /// Initializes a new instance of the Malpractice class.
        /// </summary>
        public Malpractice() { }

        /// <summary>
        /// Initializes a new instance of the Malpractice class.
        /// </summary>
        public Malpractice(CodedDescription state, string patientName, string courtName, string role, string claimStatus, string insuranceName, string explanation, DateTime? eventDate = default(DateTime?), string caseNumber = default(string), DateTime? lawsuitDate = default(DateTime?), double? judgementAmount = default(double?), double? behalfAmount = default(double?))
        {
            State = state;
            EventDate = eventDate;
            PatientName = patientName;
            CourtName = courtName;
            CaseNumber = caseNumber;
            Role = role;
            LawsuitDate = lawsuitDate;
            ClaimStatus = claimStatus;
            InsuranceName = insuranceName;
            JudgementAmount = judgementAmount;
            BehalfAmount = behalfAmount;
            Explanation = explanation;
        }

        /// <summary>
        /// State/province of malpractice
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public CodedDescription State { get; set; }

        /// <summary>
        /// Date of event
        /// </summary>
        [JsonProperty(PropertyName = "eventDate")]
        public DateTime? EventDate { get; set; }

        /// <summary>
        /// Name of patient
        /// </summary>
        [JsonProperty(PropertyName = "patientName")]
        public string PatientName { get; set; }

        /// <summary>
        /// Name of court
        /// </summary>
        [JsonProperty(PropertyName = "courtName")]
        public string CourtName { get; set; }

        /// <summary>
        /// Case number
        /// </summary>
        [JsonProperty(PropertyName = "caseNumber")]
        public string CaseNumber { get; set; }

        /// <summary>
        /// Role of practitioner in claim
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        /// <summary>
        /// Date of lawsuit
        /// </summary>
        [JsonProperty(PropertyName = "lawsuitDate")]
        public DateTime? LawsuitDate { get; set; }

        /// <summary>
        /// Status of claim
        /// </summary>
        [JsonProperty(PropertyName = "claimStatus")]
        public string ClaimStatus { get; set; }

        /// <summary>
        /// Name of insurance
        /// </summary>
        [JsonProperty(PropertyName = "insuranceName")]
        public string InsuranceName { get; set; }

        /// <summary>
        /// Amount of judgement
        /// </summary>
        [JsonProperty(PropertyName = "judgementAmount")]
        public double? JudgementAmount { get; set; }

        /// <summary>
        /// Behalf amount
        /// </summary>
        [JsonProperty(PropertyName = "behalfAmount")]
        public double? BehalfAmount { get; set; }

        /// <summary>
        /// Explanation
        /// </summary>
        [JsonProperty(PropertyName = "explanation")]
        public string Explanation { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (State == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "State");
            }
            if (PatientName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PatientName");
            }
            if (CourtName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CourtName");
            }
            if (Role == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Role");
            }
            if (ClaimStatus == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ClaimStatus");
            }
            if (InsuranceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InsuranceName");
            }
            if (Explanation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Explanation");
            }
        }
    }
}
