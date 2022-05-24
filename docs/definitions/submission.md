# Submission

A submission to a board.

| Name | Type | Required | Description |
| - | - | - | - |
| id | integer | Yes | Submission ID |
| fid | string (length: 9, format: digits) | Yes | FID of practitioner. |
| submitDate | string (date/time) | Yes | Date/time of submission (not in UTC). |
| application | [Application](application.md) | Yes | Application information. |
| identity | [Identification](identification.md) | Yes | Identity information. |
| names | [Names](names.md) | Yes | Names |
| addresses | [Addresses](addresses.md) | Yes | Mailing addresses. |
| emailAddresses | [EmailAddresses](email-addresses.md) | Yes | Email addresses. |
| phones | [Phones](phones.md) | Yes | Phone numbers. |
| medicalEducation | [MedicalEducationTraining](medical-education-training.md) | No | Medical education. |
| medicalEducationTraining | | | **Deprecated**. Use `medicalEducation`. |
| postGraduateTraining | [PostGraduateTraining](post-graduate-training.md) | No | Postgraduate training. |                    
| exams | [Exam](exam.md)[] | No | Exams. |
| licenses | [License](license.md)[] | No | Licenses. |
| malpractice | [Malpractice](malpractice.md)[] | No | Malpractice information. |
| activities | [Activity](activity.md)[] | No | Chronology of activity. |
| workHistory | | | **Deprecated**. Use `activities`. |
| pdc | [PdcReport](pdc/pdc-report.md) | No | PDC information, if available. |
| addendum | object | No | |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# AccreditedTraining

Accredited training information.

| Name | Type | Required | Description |
| - | - | - | - |
| accreditationType | string | Yes | The type of accreditation (e.g. `ACMGE`, `AOA`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| programCode | string | Yes | Program code. |
| program | [Program](#program) | Yes | Program. |
| specialty | [Specialty](#specialty) | Yes | Specialty. |
| programType | string | Yes | Program type. |
| trainingStatus | string | Yes | Training status (e.g. `Active`, `Completed`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| beginDate | string (date) | Yes | Start date. |
| endDate | string (date) | Yes | End date. |
| percentageClinical | integer | No | Percentage of training that was Clinical. |
| percentageAdministrative | integer | No | Percentage of training that was Administrative. |
| isAcgme | | | **Deprecated**. Use `accreditationType`. |
| isAoa | | | **Deprecated**. Use `accreditationType`. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# Activity

Activity information.

| Name | Type | Required | Description |
| - | - | - | - |
| id | string | Yes | ID of the activity. *Note: The ID is only unique for this request.* |
| type | string | Yes | Type of activity. |
| inProgress | boolean | Yes | Is in progress? |
| beginDate | string (date) | Yes | Start date. |
| endDate | string (date) | No | End date. |
| description | string | Yes | Description. |
| addressLines | string[] | No | Address lines. |
| city | string | No | City. |
| stateOrProvince | [Region](#region) | No | State/province. |
| postalCode | string | No | Postal code. |
| position | string | No | Position. |
| department | string | No | Department. |
| wasEmployed | boolean | Yes | Was employee? |
| hadStaffPrivileges | boolean | Yes | Had staff privileges? |
| wasAffiliated | boolean | Yes | Was affiliated? |
| percentageClinical | integer | No | % clinical. |
| percentageAdminstrative | integer | No | % administrative. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# Address

Mailing address.

| Name | Type | Required | Description |
| - | - | - | - |
| addressType | string | Yes | Type of address (e.g. `Business`, `Home`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| lines | string[] | Yes | Address lines. |
| city | string | Yes | City. |
| stateOrProvince | [Region](#region) | Yes | State/province. |
| postalCode | string | Yes | Postal code. |
| zipCode | | | **Deprecated**. Use `postalCode`. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# Addresses

List of mailing addresses.

| Name | Type | Required | Description |
| - | - | - | - |
| forPublic | [Address](#address) | Yes | Public address. |
| forBoard | [Address](#address) | Yes | Board address. |
| other | [Address](#address)[] | No | Other addresses. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# Application

Application information.

| Name | Type | Required | Description |
| - | - | - | - |
| licenseType | string | Yes | Type of license (e.g. `MD`, `DO`, `PA`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| boardName | string | Yes | Board name. |
| licenseSubtypeDetails | [LicenseSubtype](#licensesubtype) | Yes | Subtype of license. |
| licenseSubtype | string | | **Deprecated**. Use `licenseSubtypeDetails`. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# Degree

Degree information.

| Name | Type | Required | Description |
| - | - | - | - |
| code | string | Yes | Code (e.g. `BM`, `MD`, `DMCH`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| description | string | Yes | Description. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# Ecfmg

ECFMG information.

| Name | Type | Required | Description |
| - | - | - | - |
| ecfmgNumber | string (format: digits) | Yes | ECFMG number. |
| issueDate | string (date) | No | Issue date. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# EmailAddress

Email address.

| Name | Type | Required | Description |
| - | - | - | - |
| email | string | Yes | Email address. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# EmailAddresses

List of email addresses.

| Name | Type | Required | Description |
| - | - | - | - |
| forPublic | [EmailAddress](#emailaddress) | Yes | Public email address. |
| forBoard | [EmailAddress](#emailaddress) | Yes | Board email address. |
| other | [EmailAddress](#emailaddress)[] | No | Other email addresses. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# Exam

Exam. 

| Name | Type | Required | Description |
| - | - | - | - |
| examType | string | Yes | Type of exam. |
| stateBoardDetail | [StateProvince](#stateprovince) | No | State board description. |
| examDate | string (date) | Yes | Exam date. |
| numberOfAttempts | integer | Yes | Number of attempts. |
| passFail | string | Yes | Pass/fail status (e.g. `Pass`, `Fail`, `Unknown`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| stateBoard | | | **Deprecated**. Use `stateBoardDetail`. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# FifthPathway

Fifth Pathway information.

| Name | Type | Required | Description |
| - | - | - | - |
| school | [FifthPathwaySchool](#fifthpathwayschool) | Yes | School. |
| startDate | string (date) | Yes | Start date. |
| endDate | string (date) | Yes | End date. |
| certificateDate | string (date) | Yes | Certification date. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# FifthPathwaySchool

Fifth Pathway school information.

| Name | Type | Required | Description |
| - | - | - | - |
| name | string | Yes | School name. |
| affiliatedInstitution | string | Yes | Affiliated institution. |
| city | string | No | City. |
| stateOrProvince | [Region](#region) | No | State/province. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# Identification

Identity information.

| Name | Type | Required | Description |
| - | - | - | - |
| ssn | string (length: 9, format: digits) | No | SSN. |
| ssnLast4 | string (length: 4, format: digits) | No | Last 4 of the SSN. |
| npi | string (length: 10, format: digits) | No | NPI. |
| usmleId | string (length: 8, format: digits) | No | USMLE ID. |
| isUSCitizen | string | No | US citizen indicator. |
| birthDate | string (date) | Yes | Date of birth. |
| birthCity | string | Yes | Place of birth. |
| birthStateOrProvince | [Region](#region) | No | State/province of birth. |
| gender | string | Yes | Gender. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# License

License information.

| Name | Type | Required | Description |
| - | - | - | - |
| licenseType | string | No | Type of license (e.g. `TEMP`, `FULL`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| licensingEntity | [LicenseEntity](#licenseentity) | No | Entity issuing license. |
| status | string | No | License status (e.g. `Active`, `Denied`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| practitionerType | [PractitionerType](#practitionertype) | No | Practitioner type. |
| licenseNumber | string | No | License number. |
| issueDate | string (date) | No | Issue date. |
| expirationDate | string (date) | No | Expiration date. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# LicenseEntity

Entity issuing license.

| Name | Type | Required | Description |
| - | - | - | - |
| code | string | Yes | Entity code. Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| description | string | Yes | Description. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# LicenseSubtype

License subtype information.

| Name | Type | Required | Description |
| - | - | - | - |
| code | string | Yes | Code (e.g. `FULL`, `TEMP`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| description | string | Yes | Description. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# Malpractice

Malpractice Information.

| Name | Type | Required | Description |
| - | - | - | - |
| state | [Region](#region) | Yes | State/province of malpractice. |
| eventDate | string (date) | Yes | Date of event. |
| patientName | string | Yes | Name of patient. |
| courtName | string | Yes | Name of court. |
| caseNumber | string | No | Case number. |
| role | string | Yes | Role of practitioner in claim. |
| lawsuiteDate | string (date) | Yes | Date of lawsuit. |
| claimStatus | string | Yes | Status of claim. |
| insuranceName | string | Yes | Name of insurance. |
| judgementAmount | number | No | Amount of judgement. |
| behalfAmount | number | No | Behalf amount. |
| explanation | string | Yes | Explanation. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# MedicalEducation

Medical school education.

| Name | Type | Required | Description |
| - | - | - | - |
| school | [School](#school) | Yes | Medical school. |
| beginDate | string (date) | Yes | Start date. |
| endDate | string (date) | Yes | End date. |
| degree | [Degree](#degree) | No | Degree information. |
| graduationDate | string (date) | No | Graduation date. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# MedicalEducationTraining

List of medical education.

| Name | Type | Required | Description |
| - | - | - | - |
| isInternationalGraduate | boolean | Yes | Is international graduate? |
| graduating | [MedicalEducation](#medicaleducation) | Yes | Graduating school. |
| other | [MedicalEducation](#medicaleducation)[] | No | Other medical schools. |
| ecfmg | [Ecfmg](#ecfmg) | No | ECFMG information. |
| fifthPathway | [FifthPathway](#fifthpathway) | No | 5th Pathway information. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# Name

Name of a person.

| Name | Type | Required | Description |
| - | - | - | - |
| firstName | string | Yes | First name. |
| middleName | string | No | Middle name. |
| lastName | string | Yes | Last name. |
| suffix | string | No | Suffix. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# Names

List of names.

| Name | Type | Required | Description |
| - | - | - | - |
| legalName | [Name](#name) | Yes | Legal name. |
| other | [Name](#name)[] | No | Other names. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# OtherTraining

Non-accredited postgraduate training.

| Name | Type | Required | Description |
| - | - | - | - |
| program | [Program](#program) | Yes | Program. |
| specialty | [Specialty](#specialty) | Yes | Specialty. |
| programType | string | Yes | Program type (e.g. `Internship`, `Fellowship`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| trainingStatus | string | Yes | Training status (e.g. `Active`, `Completed`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| beginDate | string (date) | Yes | Start date. |
| endDate | string (date) | Yes | End date. |
| percentageClinical | integer | No | Percentage of training that was Clinical. |
| percentageAdministrative | integer | No | Percentage of training that was Administrative. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# Phone

Phone number.

| Name | Type | Required | Description |
| - | - | - | - |
| phoneType | string | Yes | Type of home (e.g. `Business`, `Home`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| phoneNumber | string | Yes | Phone number. |
| extension | string | No | Phone extension. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# Phones

List of phone numbers.

| Name | Type | Required | Description |
| - | - | - | - |
| forPublic | [Phone](#phone) | Yes | Public phone. |
| forBoard | [Phone](#phone) | Yes | Board phone. |
| other | [Phone](#phone)[] | No | Other phone numbers. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# PostGraduateTraining

List of post graduate training.

| Name | Type | Required | Description |
| - | - | - | - |
| accreditedTraining | [AccreditedTraining](#accreditedtraining)[] | No | Accredited training. |
| otherTraining | [OtherTraining](#otherTraining)[] | No | Other training. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# PractitionerType

Practitioner type.

| Name | Type | Required | Description |
| - | - | - | - |
| code | string | Yes | Code. Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| description | string | Yes | Description. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# Program

Postgraduate training program.

| Name | Type | Required | Description |
| - | - | - | - |
| hospitalName | string | Yes | Hospital name. |
| affiliatedInstitution | string | No | Affiliated institution. |
| city | string | Yes | City. |
| stateOrProvince | [Region](#region) | Yes | State or province. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# School

Medical school.

| Name | Type | Required | Description |
| - | - | - | - |
| name | string | Yes | School name. |
| cibisCode | string | No | CIBIS code. |
| schoolType | [SchoolType](#schooltype) | Yes | Type of school. |
| city | string | No | City. |
| stateOrProvince | [Region](#region) | No | State or province. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

# Specialty

Training specialty.

| Name | Type | Required | Description |
| - | - | - | - |
| description | string | Yes | Description. |
| classification | | | **Deprecated**. Use `Description`. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
