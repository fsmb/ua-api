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

JSON is not a typed language. The JSON definitions are logical types used to make it easier to discuss the layout of the data. The definition names have no meaning in JSON nor do they show up in any data sent or received. This is in contrast to XML where the "types" are defined by the XML element names.

*Note: A word of warning about case. In XML Pascal casing is generally used and it is case sensitive. In JSON camel casing is always used and it is case sensitive.*

### USMLASource

##### JSON Definition: None

This is the root element in XML and contained the submission(s). Arrays are first class citizens in JSON and therefore a wrapper type is not needed.

| XML Element | XML Type | Comments |
|:-:|:-:|:-:|-|
| USMLASource1 | [SourceUSMLA](#sourceusmla)[] | |

### SourceUSMLA

##### JSON Definition: [Submission](definitions/submission.md)

This represents a submission.

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| Username | string | | The login information is not available. A user may have multiple logins for UA. |
| SubmitId | int | `id` | |
| StateBoard | string | `application.boardName` | |
| DocumentTypeCode | string | | No equivalent. |
| SubmittedDate | string (date) | `submitDate` | The API returns the date and time of submission. The XML had only the date. |
| MDDegree | string (boolean) | `application.licenseType` | See below. |
| DODegree | string (boolean) | `application.licenseType` | See below. |
| SubmissionType | string | | No equivalent. |
| HasFCVSFlag | string (boolean) | | No equivalent. |
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

### AddressInfo
##### JSON Definition: [Address](definitions/submission.md#address)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| StreetAddressLine1 | string | `lines` | All address lines are stored in a single array. |
| StreetAddressLine2 | string | `lines` | All address lines are stored in a single array. |
| StreetAddressLine3 | string | `lines` | All address lines are stored in a single array. |
| City | string | `city` | |
| StateOrProvince | string | [stateOrProvince.code](definitions/submission.md#stateprovince) | |
| PostalCode | string | `zipCode` | |
| Country | string | [stateOrProvince.countryCode](definitions/submission.md#stateprovince) | |
| Description | string | `addressType` | |
| Mailing | string (yes/no) | | This field is defined in [Addresses](definitions/submission.md#addresses) |
| Privacy | string | | This field is defined in [Addresses](definitions/submission.md#addresses) |

### ContactInfo
##### JSON Definition: None

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| AddressInfo | [AddressInfo](#addressinfo)[] | [addresses](definitions/submission.md#addresses) | See below. |
| Telephone | [TelephoneInfo](#telephoneinfo)[] | [phones](definitions/submission.md#phones) | See below. |
| EmailAddress | [EmailInfo](#emailinfo)[] | [emailAddresses](definitions/submission.md#emiladdresses) | See below. |

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
| ExpirationDAte | | Not available in JSON. *Note: The casing is incorrect for this field in the XML.* |

### EmailAddress
##### JSON Definition: [EmailAddress](definitions/submission.md#emailaddress)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
| Email | string | `email` | |
| Description | string | | UA does not support type for email. |

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
##### JSON Definition: [](definitions/submission.md#)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|

### Licensure
##### JSON Definition: [](definitions/submission.md#)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|

### MedicalEducationInfo
##### JSON Definition: [](definitions/submission.md#)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|

### NameInfo
##### JSON Definition: [](definitions/submission.md#)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|

### PersonalInfo
##### JSON Definition: [](definitions/submission.md#)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|

### PostGraduateTrainingInfo
##### JSON Definition: [](definitions/submission.md#)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|

### TelephoneInfo
##### JSON Definition: [](definitions/submission.md#)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|

### WorkHistory
##### JSON Definition: [](definitions/submission.md#)

| XML Element | XML Type | JSON Field | Comments |
|:-:|:-:|:-:|-|
