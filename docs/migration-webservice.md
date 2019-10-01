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
| Username | string | | Not supported. A user may have multiple logins for UA. |
| SubmitId | int | `id` | |
| StateBoard | string | `application.boardName` | |
| DocumentTypeCode | string | | Not supported. |
| SubmittedDate | string (date) | `submitDate` | The API returns the date and time of submission. The XML had only the date. |
| MDDegree | string (boolean) | `application.licenseType` | See below. |
| DODegree | string (boolean) | `application.licenseType` | See below. |
| SubmissionType | string | | No equivalent. |
| HasFCVSFlag | string (boolean) | | Not supported. |
| Physician | [Physician](#physician) | |

`MDDegree` and `DODegree` are boolean strings in XML indicating what type of license is being submitted. In JSON this is combined into a single license type because a submission can have only one license type.

### Physician

###### JSON Definition: [Submission](definitions/submission.md)

This represents the physician data. XML required a wrapper element to store the data. In JSON it is at the same level as the submission.

| XML Element | XML Type | JSON Field |
|:-:|:-:|:-:|
| NameInfo | [NameInfo](#nameinfo) | [names](definitions/submission.md#names) |
| PersonalInfo | [PersonalInfo](#personalinfo) | [identity](definitions/submission.md#identification) |
| ECFMGInfo | [ECFMGInfo](#ecfmginfo) | [medicalEducation.ecfmg](definitions/submission.md#ecfmg) |
| MedicalEducationInfo | [MedicalEducationInfo](#medicaleducationinfo)[] | [medicalEducation](definitions/submission.md#medicaleducation) |
| PostGraduateTrainingInfo | [PostGraduateTrainingInfo](#postgraduatetraininginfo)[] | [postGraduateTraining](definitions/submission.md#postgraduatetraining) | 
| FifthPathwayInfo | [fifthPathwayInfo](#fifthpathwayinfo) | [medicalEducation.fifthPathway](definitions/submission.md#fifthpathway) |
| ExamHistory | [ExaminationHistory](#examinationhistory)[] | [exams](definitions/submission.md#exam) |
| LicensureInfo | [Licensure](#licensure)[] | [licenses](definitions/submission.md#license) |
| WorkHistory | [WorkHistory](#workhistory)[] | [activities](definitions/submission.md#activity) |
| MalpracticeClaims | ? | [malpractice](definitions/submission.md#malpractice) |
| ContactInfo | [ContactInfo](#contactinfo) | |

### AccreditedTraining
##### JSON Definition: [accreditedTraining](definitions/submission.md#accreditedTraining)

Each distinct program/specialty is listed as a separate accredited training entry.

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| InstitutionInfo.InstitutionName | string | `program.hospitalName` | |
| InstitutionInfo.InstitutionAddress.StreetAddressLine1 | string | | Not supported. |
| InstitutionInfo.InstitutionAddress.StreetAddressLine2 | string | | Not supported. |
| InstitutionInfo.InstitutionAddress.StreetAddressLine3 | string | | Not supported. |
| InstitutionInfo.InstitutionAddress.City | string | `program.city` | |
| InstitutionInfo.InstitutionAddress.StateOrProvince | string | `program.stateOrProvince.description` | |
| InstitutionInfo.InstitutionAddress.PostalCode | string | | Not supported. |
| InstitutionInfo.InstitutionAddress.Country | string | `program.stateOrProvince.countryCode` | |
| InstitutionInfo.InstitutionAddress.Description | string | | Not supported. |
| TrainingYears.ProgramDescription | string | `programType` | |
| TrainingYears.DepartmentPosition | string | `specialty.description` | |
| TrainingYears.StatusDescription | string | `trainingStatus` | |
| TrainingYears.TrainingLevel | string | ?? | |
| TrainingYears.TrainingDates.BeginMonth | string (format: mm) | `beginDate` | See below. |
| TrainingYears.TrainingDates.BeginYear | string (format: yyyy) | `beginDate` | See below. |
| TrainingYears.TrainingDates.EndMonth | string (format: mm) | `endnDate` | See below. |
| TrainingYears.TrainingDates.EndYear | string (format: yyyy) | `endnDate` | See below. |
| TrainingYears.TrainingDates.InProgressFlag | string (`Y`, `N`) | | Not supported. |

### AddressInfo
##### JSON Definition: [Address](definitions/submission.md#address)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| StreetAddressLine1 | string | `lines` | All address lines are stored in a single array. |
| StreetAddressLine2 | string | `lines` | All address lines are stored in a single array. |
| StreetAddressLine3 | string | `lines` | All address lines are stored in a single array. |
| City | string | `city` | |
| StateOrProvince | string | `stateOrProvince.code` | |
| PostalCode | string | `zipCode` | |
| Country | string | `stateOrProvince.countryCode` | |
| Description | string | `addressType` | |
| Mailing | string (`Y`, `N`) | | See below. |
| Privacy | string | | See below. |

The `Mailing` and `Privacy` XML elements are managed by [addresses](definitions/submission.md#addresses) rather than on the address itself.

### ContactInfo
##### JSON Definition: None

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| AddressInfo | [AddressInfo](#addressinfo)[] | [addresses](definitions/submission.md#addresses) | See below. |
| Telephone | [TelephoneInfo](#telephoneinfo)[] | [phones](definitions/submission.md#phones) | See below. |
| EmailAddress | [EmailInfo](#emailinfo)[] | [emailAddresses](definitions/submission.md#emailaddresses) | See below. |

The XML grouped contact information into 3 separate arrays. Client code had to enumerate the array to identify which contact information was for public or board use. 

The JSON breaks contact information up into 3 separate objects. Each object exposes the following.

| JSON Field | Comments |
|:-:|-|
| `forBoard` | Contains contact information for the board. |
| `forPublic` | Contains contact information for the public. |
| `other` | Array containing any additional contact information. |

A client can either retrieve the specific contact information (e.g. board or public) or combine them all together depending upon its needs.

### ECFMGInfo
##### JSON Definition: [Ecfmg](definitions/submission.md#ecfmg)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| ECFMGid | string | `ecfmgNumber` | |
| CertificationDate | string (date) `issueDate` | |
| ExpirationDAte | | Not supported. *Note: The casing is incorrect for this field in the XML.* |

### EmailInfo
##### JSON Definition: [EmailAddress](definitions/submission.md#emailaddress)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| Email | string | `email` | |
| Description | string | | Not supported. UA does not collect this information. |

### ExaminationHistory
##### JSON Definition: [exam](definitions/submission.md#exam)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| ExamName | string | `examType` | | 
| StateCode | string | ??? |
| ExamDate | string (format: month/year) | `examDate` | |
| NumberOfAttempts | int | `numberOfAttempts` | |
| PassFailFlag | string (e.g. `P') | `passFail` | |

### FifthPathwayInfo
##### JSON Definition: [fifthPathway](definitions/submission.md#fifthpathway)

???

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|

### Licensure
##### JSON Definition: [license](definitions/submission.md#license)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| LicenseNumber | string | `licenseNumber` | | 
| LicenseStateCode | string | `licensingEntity.code` | | 
| LicenseTypeCode | string | | Not supported. | 
| LicenseTypeDesc | string | | Not supported. | 
| LicenseStatus | string | `status` | | 
| LicenseIssueDate | string | `issueDate` | | 
| LicenseSubtypeCode | string | | Not supported. | 
| LicenseSubtypeDesc | string | `licenseType` | | 

### MedicalEducationInfo
##### JSON Definition: [medicalEducation](definitions/submission.md#medicalEducation)

In the XML this is an array of `MedicalEducationInfo` elements. In JSON the definition [medicalEducationTraining](definitions/submission.md#medicalEducationTraining) wraps medical education to make it easier to get the graduating school.

| JSON Field | Comments |
|:-:|-|
| `graduating` | Contains the school of graduation. |
| ??`other` | Contains any other medical schools that the practitioner attended. |

The following mapping applies to each school attended.

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| Degree | string | `degree.code` | Only set if this a graduating school.
| GraduationDate | string (format: mm/dd/yyyy) | `graduationDate` | Only set if this is a graduating school.
| SchoolInfo | [SchoolInfo](#schoolInfo) | `school` | 
| MedicalEducationDatesEnrolled.BeginMonth | string (format: mm) | `beginDate` | See below. |
| MedicalEducationDatesEnrolled.BeginYear | string (format: yyyy) | `beginDate` | See below. |
| MedicalEducationDatesEnrolled.EndMonth | string (format: mm) | `endDate` | See below. |
| MedicalEducationDatesEnrolled.EndYear | string (format: yyyy) | `endDate` | See below. | 
| MedicalEducationDatesEnrolled.InProgressFlag | string (`Y`, `N`) | | Not supported. |

The `beginDate` and `endDate` are the dates that the practitioner started or ended attendance. The day is collected by UA but in general should be ignored.

### NameInfo
##### JSON Definition: [name](definitions/submission.md#name)

In the XML this is an array of `NameInfo` elements. In JSON the definition [names](definitions/submission.md#names) wraps the names. 

| JSON Field | Comments |
|:-:|-|
| `legalName` | Contains the legal name of the practitioner. |
| ??`other` | Contains alternate names provided by the practitioner. |

The following mappings applies to the name elements.

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| FirstName | string | `firstName` | |
| MiddleName | string | `middleName` | |
| LastName | string | `lastName` | |
| Suffix | string | `suffix` | |
| MaidenName | string | | Not supported. |
| AlternateName | string | | Handled by the [names](definitions/submission.md#names) definition. |

## OtherTraining
##### JSON Definition: [otherTraining](definitions/submission.md#otherTraining)
???

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| InstitutionInfo.InstitutionName | string | `program.hospitalName` | |
| InstitutionInfo.InstitutionAddress.StreetAddressLine1 | string | | Not supported. |
| InstitutionInfo.InstitutionAddress.StreetAddressLine2 | string | | Not supported. |
| InstitutionInfo.InstitutionAddress.StreetAddressLine3 | string | | Not supported. |
| InstitutionInfo.InstitutionAddress.City | string | `program.city` | |
| InstitutionInfo.InstitutionAddress.StateOrProvince | string | `program.stateOrProvince.description` | |
| InstitutionInfo.InstitutionAddress.PostalCode | string | | Not supported. |
| InstitutionInfo.InstitutionAddress.Country | string | `program.stateOrProvince.countryCode` | |
| InstitutionInfo.InstitutionAddress.Description | string | | Not supported. |
| TrainingYears.ProgramDescription | string | `programType` | |
| TrainingYears.DepartmentPosition | string | `specialty.description` | |
| TrainingYears.StatusDescription | string | `trainingStatus` | |
| TrainingYears.TrainingLevel | string | ?? | |
| TrainingYears.TrainingDates.BeginMonth | string (format: mm) | `beginDate` | See below. |
| TrainingYears.TrainingDates.BeginYear | string (format: yyyy) | `beginDate` | See below. |
| TrainingYears.TrainingDates.EndMonth | string (format: mm) | `endnDate` | See below. |
| TrainingYears.TrainingDates.EndYear | string (format: yyyy) | `endnDate` | See below. |
| TrainingYears.TrainingDates.InProgressFlag | string (`Y`, `N`) | | Not supported. |

### PersonalInfo
##### JSON Definition: [identity](definitions/submission.md#identity)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| Gender | string (e.g. `M`) | `gender` | |
| SSN | string (length: 9, format: digits) | `ssn` | |
| NPID | string (length: 10, format: digits) | `npi` | |
| USACitizenFlag | string (`Y`, `N`) | `isUSCitizen` | |
| BirthInfo.BirthDate | string (format: mm/dd/yyyy) | `birthDate` | |
| BirthInfo.BirthCity | string | `birthCity` | |
| BirthInfo.BirthStateOrProvince | string | `birthStateOrProvince.description` | |
| BirthInfo.BirthCountry | string | `birthStateOrProvince.countryDescription` | |

### PostGraduateTrainingInfo
##### JSON Definition: [postGraduateTraining](definitions/submission.md#postGraduateTraining)

In the XML post graduate training was combined into an array. In JSON the accredited training is a separate array from non-accredited training.

| JSON Field | Comments |
|:-:|-|
| `accreditedTraining` | Array of [accreditedTraining](#accreditedTraining). |
|?? `otherTraining` | Array of [otherTraining](#otherTraining). |

### TelephoneInfo
##### JSON Definition: [phone](definitions/submission.md#phone)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| phone_number | string (format: ###-###-####) | `phoneNumber`| |
| alt_phone_number | string (format: ###-###-####) | | Not supported. |
| fax_number | string (format: ###-###-####) | | Not supported. |
| address_type | string | | `phoneType` | |

### SchoolInfo
##### JSON Definition: [school](definitions/submission.md#school)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| SchoolName | string | `name` | | 
| SchoolAddress.StreetAddressLine1 | string | | Not supported. |
| SchoolAddress.StreetAddressLine2 | string | | Not supported. |
| SchoolAddress.StreetAddressLine3 | string | | Not supported. |
| SchoolAddress.City | string | `city` | |
| SchoolAddress.StateOrProvince | string | `stateOrProvince.code` | |
| SchoolAddress.PostalCode | string | | Not supported. |
| SchoolAddress.Country | string | `stateOrProvince.countryCode` | |
| SchoolAddress.Description | string | | Not supported. |

### WorkHistory
##### JSON Definition: [activity](definitions/submission.md#activity)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| EmployerName | string | `description` | |
| Position | string | `position` | |
| Department | string | `department` | |
| Employment | string (`Y`, `N`) | `wasEmployed` | |
| Staff | string (`Y`, `N`) | `hadStaffPrivileges` | |
| Affiliation | string (`Y`, `N`) | `wasAffiliated` | |
|? Other | string | | |
|? OtherDesc | string | | |
| PercentClinical | string (format: ###) | `percentageClinical` | |
| PercentAdministrative | string (format: ###) | `percentageAdministrative` | |
| WorkHistoryDates.BeginMonth | string (format: mm) | `beginDate` | |
| WorkHistoryDates.BeginYear | string (format: yyyy) | `beginDate` | |
| WorkHistoryDates.EndMonth | string (format: mm) | `endDate` | |
| WorkHistoryDates.EndYear | string (format: yyyy) | `endDate` | |
| WorkHistoryDates.InProgressFlag | string (`Y`, `N`) | `inProgress` | |
| WorkHistoryAddress.StreetAddressLine1 | string | `addressLines` | |
| WorkHistoryAddress.StreetAddressLine2 | string | `addressLines` | |
| WorkHistoryAddress.StreetAddressLine3 | string | `addressLines` | |
| WorkHistoryAddress.City | string | `city` | |
| WorkHistoryAddress.StateOrProvince | string | `stateOrProvince.description` | |
| WorkHistoryAddress.PostalCode | string | `postalCode` | |
| WorkHistoryAddress.Country | string | `stateOrProvince.countryCode` | |
| WorkHistoryAddress.Description | string | | Not supported. |
