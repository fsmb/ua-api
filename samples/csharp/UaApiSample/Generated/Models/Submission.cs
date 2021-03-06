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
    /// A submission
    /// </summary>
    public partial class Submission
    {
        /// <summary>
        /// Initializes a new instance of the Submission class.
        /// </summary>
        public Submission() { }

        /// <summary>
        /// Initializes a new instance of the Submission class.
        /// </summary>
        public Submission(string fid, Application application, Identification identity, Names names, Addresses addresses, EmailAddresses emailAddresses, Phones phones, long? id = default(long?), DateTime? submitDate = default(DateTime?), MedicalEducationTraining medicalEducation = default(MedicalEducationTraining), PostGraduateTraining postGraduateTraining = default(PostGraduateTraining), IList<Exam> exams = default(IList<Exam>), IList<License> licenses = default(IList<License>), IList<Malpractice> malpractice = default(IList<Malpractice>), IList<Activity> activities = default(IList<Activity>), object addendum = default(object))
        {
            Id = id;
            Fid = fid;
            SubmitDate = submitDate;
            Application = application;
            Identity = identity;
            Names = names;
            Addresses = addresses;
            EmailAddresses = emailAddresses;
            Phones = phones;
            MedicalEducation = medicalEducation;
            PostGraduateTraining = postGraduateTraining;
            Exams = exams;
            Licenses = licenses;
            Malpractice = malpractice;
            Activities = activities;
            Addendum = addendum;
        }

        /// <summary>
        /// Submission ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long? Id { get; set; }

        /// <summary>
        /// FID of practitioner
        /// </summary>
        [JsonProperty(PropertyName = "fid")]
        public string Fid { get; set; }

        /// <summary>
        /// Date/time of submission
        /// </summary>
        [JsonProperty(PropertyName = "submitDate")]
        public DateTime? SubmitDate { get; set; }

        /// <summary>
        /// Application information
        /// </summary>
        [JsonProperty(PropertyName = "application")]
        public Application Application { get; set; }

        /// <summary>
        /// Identity information
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identification Identity { get; set; }

        /// <summary>
        /// Names
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public Names Names { get; set; }

        /// <summary>
        /// Mailing addresses
        /// </summary>
        [JsonProperty(PropertyName = "addresses")]
        public Addresses Addresses { get; set; }

        /// <summary>
        /// Email addresses
        /// </summary>
        [JsonProperty(PropertyName = "emailAddresses")]
        public EmailAddresses EmailAddresses { get; set; }

        /// <summary>
        /// Phone numbers
        /// </summary>
        [JsonProperty(PropertyName = "phones")]
        public Phones Phones { get; set; }

        /// <summary>
        /// Medical education
        /// </summary>
        [JsonProperty(PropertyName = "medicalEducation")]
        public MedicalEducationTraining MedicalEducation { get; set; }

        /// <summary>
        /// Postgraduate training
        /// </summary>
        [JsonProperty(PropertyName = "postGraduateTraining")]
        public PostGraduateTraining PostGraduateTraining { get; set; }

        /// <summary>
        /// Exams
        /// </summary>
        [JsonProperty(PropertyName = "exams")]
        public IList<Exam> Exams { get; set; }

        /// <summary>
        /// Licenses
        /// </summary>
        [JsonProperty(PropertyName = "licenses")]
        public IList<License> Licenses { get; set; }

        /// <summary>
        /// Malpractice information
        /// </summary>
        [JsonProperty(PropertyName = "malpractice")]
        public IList<Malpractice> Malpractice { get; set; }

        /// <summary>
        /// Chronology of activity
        /// </summary>
        [JsonProperty(PropertyName = "activities")]
        public IList<Activity> Activities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addendum")]
        public object Addendum { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Fid == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Fid");
            }
            if (Application == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Application");
            }
            if (Identity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Identity");
            }
            if (Names == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Names");
            }
            if (Addresses == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Addresses");
            }
            if (EmailAddresses == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EmailAddresses");
            }
            if (Phones == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Phones");
            }
            if (this.Application != null)
            {
                this.Application.Validate();
            }
            if (this.Identity != null)
            {
                this.Identity.Validate();
            }
            if (this.Names != null)
            {
                this.Names.Validate();
            }
            if (this.Addresses != null)
            {
                this.Addresses.Validate();
            }
            if (this.EmailAddresses != null)
            {
                this.EmailAddresses.Validate();
            }
            if (this.Phones != null)
            {
                this.Phones.Validate();
            }
            if (this.MedicalEducation != null)
            {
                this.MedicalEducation.Validate();
            }
            if (this.Exams != null)
            {
                foreach (var element in this.Exams)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.Malpractice != null)
            {
                foreach (var element1 in this.Malpractice)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (this.Activities != null)
            {
                foreach (var element2 in this.Activities)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
