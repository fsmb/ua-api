# Migrating from the UA Web Service

Migrating from the UA web service to the UA API will require some significant changes to client code. The UA web service was written back when SOAP was the predominant protocol for server to server communication. XML was the defacto format for data transmission. Today [REST APIs](https://github.com/fsmb/api-docs/blob/master/docs/rest.md) are the preferred communication protocol and JSON is the defacto data format. REST is supported in any language and on any platform that supports web browsing and uses the same ports so no additional firewall rules are needed.

The security landscape has also changed. When the UA web service was released SSL and IP address filtering were the normal security practices in combination with a user name and password. Today SSL has been replaced with TLS 1.1 and IP address filtering is mostly useless given the sophisticated hacking technologies available. [OAuth2](https://github.com/fsmb/api-docs/blob/master/docs/authentication.md) has become the authentication protocol for server to server APIs.

The UA API provides the following benefits over the UA web service.

- Works on any platform and with any language that supports HTTP (the web browsing protocol) without the need for complex code or proxies.
- Supports standard HTTP features like consistent responses, server caching and redirects.
- Uses a simple HTTP-based convention for working with clients.
- Uses OAuth2 to allow for "least privilege" access to data.
- Uses JSON which is an easy to read and write data format that is more concise than XML and more flexible.
- Is accessible over the standard HTTP(S) ports so no additional firewall rules are needed.

Refer to the [Getting Started](https://github.com/fsmb/api-docs) documentation on how to get started using FSMB APIs. 

## Getting Available Submissions

In the UA web service a method was provided to get the submissions that had occurred since the last request. This required that clients call the method to retrieve the data. Each new submission was sent back to the caller and it was marked as "read". Subsequent calls to the method would no longer return the submission. There are some issues with this approach.

1. If any errors occurred after the submission was marked as read then the submission would be lost. This would be especially difficult to detect if the failure occurred while sending the submissions back to the client as the client may never have a record of the submissions.
1. Each call to retrieve the submissions potentially changed their state making it hard to test code that called the service since subsequent requests would not return the earlier data.
1. Submission status was shared by all users for the board. If a board needed to run different processes for different submission types then it had to read them all in a single process and then divide the submissions up manually.

The API does not support the concept of a "read" submission. It is up to each client to determine whether a submission has been seen before or not. It is recommended that a client retrieve a summary of submissions for the date range appropriate for the frequency at which the API is called. For example if a client needs to process submissions only once a day then it makes sense to retrieve all submissions in the last 24-36 hours. 

After getting the available submissions a client can compare the submission ID to each submission it has already processed successful in its back end system. The submission ID is guaranteed unique. If processing fails for any reason then the submission can be retrieved the next time and another attempt made to process it. The API does allow retrieving specific submissions by ID if a client needs to retrieve a specific submission during error recovery.

*Note: Clients should not rely on the sequential ordering of submission IDs.*

The web service provided a method for getting all submissions after a given ID. This does not work in the API. Submission IDs are guaranteed unique but not guaranteed to be sequential. It is possible for a lower ID to be returned in subsequent calls to the API. 

## Mapping XML to JSON

The biggest challenge for migrating from the UA web service to the API is mapping the existing XML elements to their JSON equivalent. This section will discuss the general mapping between XML and JSON. Note that not every XML element has a corresponding JSON object. Furthermore the meaning and value of JSON objects may differ from their XML counterparts.

### General Guidelines on JSON

JSON is not a typed language. The JSON definitions are logical types used to make it easier to discuss the layout of the data. The definition names have no meaning in JSON nor do they show up in any data sent or received. This is in contrast to XML where the "types" are defined by the XML element names.

Like XML, case matters in JSON. In XML Pascal casing is generally used. In JSON camel casing is always used. Pay careful attention to casing when writing code.

In XML elements are generally provided even if they are empty. In JSON objects and values are generally only included if there is a valid. Clients should assume that missing values have their default value (empty string for strings, 0 for numbers, etc). It is also possible in JSON to get more fields than documented. Client code should only process fields that are relevant to them and ignore any other fields. It is not a breaking change to add new fields to an existing JSON object.

### USMLASource

##### JSON Definition: None

This is the root element in XML and contained the submission(s). Arrays are first class citizens in JSON and therefore a wrapper type is not needed.

| XML Element | XML Type |
|:-:|:-:|
| USMLASource1 | [SourceUSMLA](#sourceusmla)[] |

### SourceUSMLA

##### JSON Definition: [Submission](definitions/submission.md)

This represents a submission.

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| DocumentTypeCode | string | | Not supported. |
| DODegree | string (`Y`, `N`) | `application.licenseType` | See below. |
| HasFCVSFlag | string (`Y`, `N`) | | Not supported. |
| MDDegree | string (`Y`, `N`) | `application.licenseType` | See below. |
| Physician | [Physician](#physician) | |
| StateBoard | string | `application.boardName` | |
| SubmissionType | string | | No equivalent. |
| SubmitId | int | `id` | |
| SubmittedDate | string (date) | `submitDate` | The API returns the date and time of submission. The XML had only the date. |
| Username | string | | Not supported. A user may have multiple logins for UA. |

`MDDegree` and `DODegree` are boolean strings in XML indicating what type of license is being submitted. In JSON this is combined into a single license type because a submission can have only one license type.

### AccreditedTraining
##### JSON Definition: [accreditedTraining](definitions/submission.md#accreditedTraining)

Each distinct program/specialty is listed as a separate accredited training entry.

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| InstitutionInfo .InstitutionAddress.City | string | `program.city` | |
| InstitutionInfo .InstitutionAddress.Country | string | `program .stateOrProvince.countryCode` | |
| InstitutionInfo .InstitutionAddress.Description | string | | Not supported. |
| InstitutionInfo .InstitutionAddress.PostalCode | string | | Not supported. |
| InstitutionInfo .InstitutionAddress.StateOrProvince | string | `program .stateOrProvince.description` | |
| InstitutionInfo .InstitutionAddress.StreetAddressLine1 | string | | Not supported. |
| InstitutionInfo .InstitutionAddress.StreetAddressLine2 | string | | Not supported. |
| InstitutionInfo .InstitutionAddress.StreetAddressLine3 | string | | Not supported. |
| InstitutionInfo .InstitutionName | string | `program.hospitalName` | |
| TrainingYears.DepartmentPosition | string | `specialty.description` | |
| TrainingYears.ProgramDescription | string | `programType` | |
| TrainingYears.StatusDescription | string | `trainingStatus` | |
| TrainingYears.TrainingDates.BeginMonth | string (format: mm) | `beginDate` | |
| TrainingYears.TrainingDates.BeginYear | string (format: yyyy) | `beginDate` | |
| TrainingYears.TrainingDates.EndMonth | string (format: mm) | `endDate` | |
| TrainingYears.TrainingDates.EndYear | string (format: yyyy) | `endDate` | |
| TrainingYears.TrainingDates.InProgressFlag | string (`Y`, `N`) | | Not supported. |
| TrainingYears.TrainingLevel | string | | Not supported. |

### AddressInfo
##### JSON Definition: [Address](definitions/submission.md#address)

In the XML all addresses are combined into an array. In JSON the [addresses](definitions/submission.md#addresses) object separates them into separate objects to make it easier for clients to get just the information they need.

| JSON Field | Comments |
|:-:|-|
| `forBoard` | Contains contact information for the board. |
| `forPublic` | Contains contact information for the public. |
| `other` | Array containing any additional contact information. |

Each address has the following mapping.

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| City | string | `city` | |
| Country | string | `stateOrProvince.countryCode` | |
| Description | string | `addressType` | |
| Mailing | string (`Y`, `N`) | | See below. |
| PostalCode | string | `zipCode` | |
| Privacy | string | | See below. |
| StateOrProvince | string | `stateOrProvince.code` | |
| StreetAddressLine1 | string | `lines` | All address lines are stored in a single array. |
| StreetAddressLine2 | string | `lines` | All address lines are stored in a single array. |
| StreetAddressLine3 | string | `lines` | All address lines are stored in a single array. |

The `Mailing` and `Privacy` XML elements are managed by [addresses](definitions/submission.md#addresses) rather than on the address itself.

### ContactInfo
##### JSON Definition: None

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| AddressInfo | [AddressInfo](#addressinfo)[] | [addresses](definitions/submission.md#addresses) | See below. |
| EmailAddress | [EmailInfo](#emailinfo)[] | [emailAddresses](definitions/submission.md#emailaddresses) | See below. |
| Telephone | [TelephoneInfo](#telephoneinfo)[] | [phones](definitions/submission.md#phones) | See below. |

### ECFMGInfo
##### JSON Definition: [Ecfmg](definitions/submission.md#ecfmg)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| CertificationDate | string (date) | `issueDate` | |
| ECFMGid | string | `ecfmgNumber` | |
| ExpirationDAte | string (date)| | Not supported. |

*Note: The casing is incorrect for the field `ExpirationDAte` in the XML.*

### EmailInfo
##### JSON Definition: [EmailAddress](definitions/submission.md#emailaddress)

In the XML all addresses are combined into an array. In JSON the [emailaddresses](definitions/submission.md#emailaddresses) object separates them into separate objects to make it easier for clients to get just the information they need.

| JSON Field | Comments |
|:-:|-|
| `forBoard` | Contains contact information for the board. |
| `forPublic` | Contains contact information for the public. |
| `other` | Array containing any additional contact information. |

Each email address has the following mapping.

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| Description | string | | Not supported. UA does not collect this information. |
| Email | string | `email` | |

### ExaminationHistory
##### JSON Definition: [exam](definitions/submission.md#exam)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| ExamDate | string (format: month/year) | `examDate` | |
| ExamName | string | `examType` | | 
| NumberOfAttempts | int | `numberOfAttempts` | |
| PassFailFlag | string (`P', `F`) | `passFail` | |
| StateCode | string | `stateBoardDetail.code` | Only when the exam is a state board exam. |

### FifthPathwayInfo
##### JSON Definition: [fifthPathway](definitions/submission.md#fifthpathway)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| CertificationDate | string (date) | `certificateDate` | |
| Degree | string | | Not Supported. |
| FifthPathwayDatesEnrolled.BeginMonth | string (format: mm) | `startDate` | |
| FifthPathwayDatesEnrolled.BeginYear | string (format: yyyy) | `startDate` | |
| FifthPathwayDatesEnrolled.EndMonth | string (format: mm) | `endDate` | |
| FifthPathwayDatesEnrolled.EndYear | string (format: yyyy) | `endDate` | |
| FifthPathwayDatesEnrolled.InProgressFlag | string (`Y`, `N`) | | Not supported. |
| FifthPathwayInstitutionInfo .INSTITUTIONNAME | string | `school.affiliatedInstitution` | This is the only supported field in this element. |
| FifthPathwaySchoolInfo | [FifthPathwayMedicalSchoolInfo](#fifthpathwaymedicalschoolinfo) | `school` | | 

### FifthPathwayMedicalSchoolInfo
##### JSON Definition: [fifthPathwaySchool](definitions/submission.md#fifthpathwayschool)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| FifthPathwayMedicalSchoolAddress.ADDRESSTYPECODE | string | | Not supported. |
| FifthPathwayMedicalSchoolAddress.CITY | string | `city` | |
| FifthPathwayMedicalSchoolAddress.COUNTRY | string | `stateOrProvince.countryCode` | |
| FifthPathwayMedicalSchoolAddress.POSTALCODE | string | | Not supported. |
| FifthPathwayMedicalSchoolAddress.STATEORPROVINCE | string | `stateOrProvince.code` | |
| FifthPathwayMedicalSchoolAddress.STREETADDRESSLINE1 | string | | Not supported. |
| FifthPathwayMedicalSchoolAddress.STREETADDRESSLINE2 | string | | Not supported. |
| FifthPathwayMedicalSchoolAddress.STREETADDRESSLINE3 | string | | Not supported. |
| SCHOOLNAME | string | `name` | |

### Licensure
##### JSON Definition: [license](definitions/submission.md#license)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| LicenseIssueDate | string (date) | `issueDate` | | 
| LicenseNumber | string | `licenseNumber` | | 
| LicenseStateCode | string | `licensingEntity.code` | | 
| LicenseStatus | string | `status` | | 
| LicenseSubtypeCode | string | | Not supported. | 
| LicenseSubtypeDesc | string | `licenseType` | | 
| LicenseTypeCode | string | | Not supported. | 
| LicenseTypeDesc | string | | Not supported. | 

### MalpracticeClaimsInfo
##### JSON Definition: [malpractice](definitions/submission.md#malpractice)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| ActionState | string | `state.code` | | 
| Case | string | `caseNumber` | | 
| CaseStatus | string | `claimStatus` | | 
| CaseStatusNote | string | | Not supported. | 
| ClaimStatusCode | string | | Not supported. | 
| Court | string | `courtName` | | 
| EventMonth | string (format: mm) | `eventDate` | | 
| EventNote | string | `explanation`  | | 
| EventYear | string (format: yyyy) | `eventDate` | | 
| InsuranceCarrier | string | `insuranceName` | | 
| JudgementAmount | number | `judgementAmount` | | 
| LawsuitMonth | string (format: mm) | `lawsuiteDate` | | 
| LawsuitYear | string (format: yyyy) | `lawsuitDate` | | 
| PatientName | string | `patientName` | | 
| PaymentOnBehalfAmount | number | `behalfAmount` | | 
| Status | string | `role` | | 
| StatusNote | string | | Not supported. | 
| YourStatusCode | string | | Not supported. | 

### MedicalEducationInfo
##### JSON Definition: [medicalEducation](definitions/submission.md#medicalEducation)

In the XML this is an array of `MedicalEducationInfo` elements. In JSON the definition [medicalEducationTraining](definitions/submission.md#medicalEducationTraining) wraps medical education to make it easier to get the graduating school.

| JSON Field | Comments |
|:-:|-|
| `graduating` | Contains the school of graduation. |
| `other` | Contains any other medical schools that the practitioner attended. |

The following mapping applies to each school attended.

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| Degree | string | `degree.code` | Only set if this a graduating school.
| GraduationDate | string (date) | `graduationDate` | Only set if this is a graduating school.
| MedicalEducationDatesEnrolled.BeginMonth | string (format: mm) | `beginDate` | |
| MedicalEducationDatesEnrolled.BeginYear | string (format: yyyy) | `beginDate` | |
| MedicalEducationDatesEnrolled.EndMonth | string (format: mm) | `endDate` | |
| MedicalEducationDatesEnrolled.EndYear | string (format: yyyy) | `endDate` | | 
| MedicalEducationDatesEnrolled.InProgressFlag | string (`Y`, `N`) | | Not supported. |
| SchoolInfo | [SchoolInfo](#schoolInfo) | `school` | 

### NameInfo
##### JSON Definition: [name](definitions/submission.md#name)

In the XML this is an array of `NameInfo` elements. In JSON the definition [names](definitions/submission.md#names) wraps the names. 

| JSON Field | Comments |
|:-:|-|
| `legalName` | Contains the legal name of the practitioner. |
| `other` | Contains alternate names provided by the practitioner. |

The following mappings applies to the name elements.

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| AlternateName | string | | Handled by the [names](definitions/submission.md#names) definition. |
| FirstName | string | `firstName` | |
| LastName | string | `lastName` | |
| MaidenName | string | | Not supported. |
| MiddleName | string | `middleName` | |
| Suffix | string | `suffix` | |

## OtherTraining
##### JSON Definition: [otherTraining](definitions/submission.md#otherTraining)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| InstitutionInfo.InstitutionName | string | `program.hospitalName` | |
| InstitutionInfo.InstitutionAddress.City | string | `program.city` | |
| InstitutionInfo.InstitutionAddress.Country | string | `program.stateOrProvince.countryCode` | |
| InstitutionInfo.InstitutionAddress.Description | string | | Not supported. |
| InstitutionInfo.InstitutionAddress.PostalCode | string | | Not supported. |
| InstitutionInfo.InstitutionAddress.StateOrProvince | string | `program.stateOrProvince.description` | |
| InstitutionInfo.InstitutionAddress.StreetAddressLine1 | string | | Not supported. |
| InstitutionInfo.InstitutionAddress.StreetAddressLine2 | string | | Not supported. |
| InstitutionInfo.InstitutionAddress.StreetAddressLine3 | string | | Not supported. |
| TrainingYears.DepartmentPosition | string | `specialty.description` | |
| TrainingYears.ProgramDescription | string | `programType` | |
| TrainingYears.StatusDescription | string | `trainingStatus` | |
| TrainingYears.TrainingDates.BeginMonth | string (format: mm) | `beginDate` | |
| TrainingYears.TrainingDates.BeginYear | string (format: yyyy) | `beginDate` | |
| TrainingYears.TrainingDates.EndMonth | string (format: mm) | `endnDate` | |
| TrainingYears.TrainingDates.EndYear | string (format: yyyy) | `endnDate` | |
| TrainingYears.TrainingDates.InProgressFlag | string (`Y`, `N`) | | Not supported. |
| TrainingYears.TrainingLevel | string | | Not supported. |

### PersonalInfo
##### JSON Definition: [identification](definitions/submission.md#identification)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| BirthInfo.BirthCity | string | `birthCity` | |
| BirthInfo.BirthCountry | string | `birthStateOrProvince.countryDescription` | |
| BirthInfo.BirthStateOrProvince | string | `birthStateOrProvince.description` | |
| BirthInfo.BirthDate | string (date) | `birthDate` | |
| Gender | string (e.g. `M`) | `gender` | |
| NPID | string (length: 10, format: digits) | `npi` | |
| SSN | string (length: 9, format: digits) | `ssn` | |
| USACitizenFlag | string (`Y`, `N`) | `isUSCitizen` | |

### Physician

###### JSON Definition: [Submission](definitions/submission.md)

This represents the physician data. XML required a wrapper element to store the data. In JSON it is at the same level as the submission.

| XML Element | XML Type | JSON Field |
|:-:|:-:|:-:|
| ContactInfo | [ContactInfo](#contactinfo) | |
| ECFMGInfo | [ECFMGInfo](#ecfmginfo) | [medicalEducation.ecfmg](definitions/submission.md#ecfmg) |
| ExamHistory | [ExaminationHistory](#examinationhistory)[] | [exams](definitions/submission.md#exam) |
| FifthPathwayInfo | [FifthPathwayInfo](#fifthpathwayinfo) | [medicalEducation.fifthPathway](definitions/submission.md#fifthpathway) |
| LicensureInfo | [Licensure](#licensure)[] | [licenses](definitions/submission.md#license) |
| MalpracticeClaims | [MalpracticeClaimsInfo](#malpracticeclaimsinfo)[] | [malpractice](definitions/submission.md#malpractice) |
| MedicalEducationInfo | [MedicalEducationInfo](#medicaleducationinfo)[] | [medicalEducation](definitions/submission.md#medicaleducation) |
| NameInfo | [NameInfo](#nameinfo) | [names](definitions/submission.md#names) |
| PersonalInfo | [PersonalInfo](#personalinfo) | [identity](definitions/submission.md#identification) |
| PostGraduateTrainingInfo | [PostGraduateTrainingInfo](#postgraduatetraininginfo)[] | [postGraduateTraining](definitions/submission.md#postgraduatetraining) | 
| WorkHistory | [WorkHistory](#workhistory)[] | [activities](definitions/submission.md#activity) |

### PostGraduateTrainingInfo
##### JSON Definition: [postGraduateTraining](definitions/submission.md#postGraduateTraining)

In the XML post graduate training was combined into an array. In JSON the accredited training is a separate array from non-accredited training.

| JSON Field | Comments |
|:-:|-|
| `accreditedTraining` | Array of [accreditedTraining](#accreditedTraining). |
| `otherTraining` | Array of [otherTraining](#otherTraining). |

### TelephoneInfo
##### JSON Definition: [phone](definitions/submission.md#phone)

In the XML all addresses are combined into an array. In JSON the [phones](definitions/submission.md#phones) object separates them into separate objects to make it easier for clients to get just the information they need.

| JSON Field | Comments |
|:-:|-|
| `forBoard` | Contains contact information for the board. |
| `forPublic` | Contains contact information for the public. |
| `other` | Array containing any additional contact information. |

Each phone has the following mapping.

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| address_type | string | | `phoneType` | |
| alt_phone_number | string (format: ###-###-####) | | Not supported. |
| fax_number | string (format: ###-###-####) | | Not supported. |
| phone_number | string (format: ###-###-####) | `phoneNumber`| |

### SchoolInfo
##### JSON Definition: [school](definitions/submission.md#school)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| SchoolAddress.City | string | `city` | |
| SchoolAddress.Country | string | `stateOrProvince.countryCode` | |
| SchoolAddress.Description | string | | Not supported. |
| SchoolAddress.PostalCode | string | | Not supported. |
| SchoolAddress.StateOrProvince | string | `stateOrProvince.code` | |
| SchoolAddress.StreetAddressLine1 | string | | Not supported. |
| SchoolAddress.StreetAddressLine2 | string | | Not supported. |
| SchoolAddress.StreetAddressLine3 | string | | Not supported. |
| SchoolName | string | `name` | | 

### WorkHistory
##### JSON Definition: [activity](definitions/submission.md#activity)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| Affiliation | string (`Y`, `N`) | `wasAffiliated` | |
| Department | string | `department` | |
| EmployerName | string | `description` | |
| Employment | string (`Y`, `N`) | `wasEmployed` | |
| Other | string | | Not supported. |
| OtherDesc | string | | Not supported. |
| PercentAdministrative | string (format: ###) | `percentageAdministrative` | |
| PercentClinical | string (format: ###) | `percentageClinical` | |
| Position | string | `position` | |
| Staff | string (`Y`, `N`) | `hadStaffPrivileges` | |
| WorkHistoryAddress.City | string | `city` | |
| WorkHistoryAddress.Country | string | `stateOrProvince.countryCode` | |
| WorkHistoryAddress.Description | string | | Not supported. |
| WorkHistoryAddress.PostalCode | string | `postalCode` | |
| WorkHistoryAddress.StateOrProvince | string | `stateOrProvince.description` | |
| WorkHistoryAddress.StreetAddressLine1 | string | `addressLines` | |
| WorkHistoryAddress.StreetAddressLine2 | string | `addressLines` | |
| WorkHistoryAddress.StreetAddressLine3 | string | `addressLines` | |
| WorkHistoryDates.BeginMonth | string (format: mm) | `beginDate` | |
| WorkHistoryDates.BeginYear | string (format: yyyy) | `beginDate` | |
| WorkHistoryDates.EndMonth | string (format: mm) | `endDate` | |
| WorkHistoryDates.EndYear | string (format: yyyy) | `endDate` | |
| WorkHistoryDates.InProgressFlag | string (`Y`, `N`) | `inProgress` | |
