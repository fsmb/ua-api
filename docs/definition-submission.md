# Submission

A submission to a board.

| Name | Type | Description |
| - | - | - |
| id | integer | Required. Submission ID |
| fid | string | Required. FID of practitioner. |
| submitDate | DateTime | Required. Date/time of submission (not in UTC). |
| application | [Application](#application) | Required. Application information. |
| identity | [Identification](#identification) | Required. Identity information. |
| names | [Names](#names) | Required. Names |
| addresses | [Addresses](#addresses) | Required. Mailing addresses. |
| emailAddresses | [EmailAddresses](#emailaddresses) | Required. Email addresses. |
| phones | [Phones](#phones) | Required. Phone numbers. |
| medialEducation | [MedicalEducationTraining](#medicaleducationtraining) | Medical education. |
| postGraduateTraining | [PostGraduateTraining](#postgraduatetraining) | Postgraduate training. |                    
| exams | [Exam[]](#exam) | Exams. |
| licenses | [License[]](#license) | Licenses. |
| malpractice | [Malpractice[]](#malpractice) | Malpractice information. |
| activities | [Activity[]](#activity) | Chronology of activity. |
| addendum | object | |

## AccreditedTraining

Accredited training information.

| Name | Type | Description |
| - | - | - |
| accreditationType | string | Required. The type of accreditation (e.g. ACGME, AOA). |
| programCode | string | Required. Program code. |
| program | [Program](#program) | Required. Program. |
| specialty | [Specialty](#specialty) | Required. Specialty. |
| programType | string | Required. Program type. |
| trainingStatus | string | Required. Training status. |
| beginDate | string (date) | Required. Start date. |
| endDate | string (date) | Required. End date. |
| percentageClinical | integer | Percentage of training that was Clinical. |
| percentageAdministrative | integer | Percentage of training that was Administrative. |
        
## Activity

Activity information.

| Name | Type | Description |
| - | - | - |
| id | string | ID of the activity. |
| type | string | Required. Type of activity. |
| inProgress | boolean | Required. Is in progress? |
| beginDate | string (date) | Required. Start date. |
| endDate | string (date) | End date. |
| description | string | Required. Description. |
| addressLines | string[] | Address lines. |
| city | string | City. |
| stateOrProvince | [Region](#region) | State/province. |
| postalCode | string | Postal code. |
| position | string | Position. |
| department | string | Department. |
| wasEmployed | boolean | Required. Was employee? |
| hadStaffPrivileges | boolean | Required. Had staff privileges? |
| wasAffiliated | boolean | Required. Was affiliated? |
| percentageClinical | integer | % clinical. |
| percentageAdminstrative | integer | % administrative. |

## Address

Mailing address.

| Name | Type | Description |
| - | - | - |
| addressType | string | Required. Type of address (e.g. Business, Home). |
| lines | string[] | Address lines. |
| city | string | Required. City. |
| stateOrProvince | [Region](#region) | Required. State/province. |
| postalCode | string | Required. Postal code. |

## Addresses

Mailing addresses.

| Name | Type | Description |
| - | - | - |
| forPublic | [Address](#address) | Public address. |
| forBoard | [Address](#address) | Board address. |
| other | [Address[]](#address) | Other addresses. |

## Application

| Name | Type | Description |
| - | - | - |
| licenseType | string | Type of license (e.g. MD, DO, PA). |
| boardName | string | Board name. |
| licenseSubtype | string | Subtype of license (e.g. Permanent Medical License). |

## CodedDescription

| Name | Type | Description |
| - | - | - |
| code | string | Code. |
| description | string | Description. |

## Ecfmg

ECFMG information.

| Name | Type | Description |
| - | - | - |
| ecfmgNumber | string | Required. ECFMG number. |
| issueDate | string (date) | Issue date. |

## EmailAddress

Email address.

| Name | Type | Description |
| - | - | - |
| email | string | Email address. |

## EmailAddresses

Email information.

| Name | Type | Description |
| - | - | - |
| forPublic | [EmailAddress](#emailaddress) | Public email. |
| forBoard | [EmailAddress](#emailaddress) | Board email. |
| other | [EmailAddress[]](#emailaddress) | Other emails. |

## Exam

Exam. 

| Name | Type | Description |
| - | - | - |
| examType | string | Required. Type of exam. |
| stateBoardDetail | [CodedDescription](#codeddescription) | State code and board description. |
| examDate | string (date) | Required. Exam date. |
| numberOfAttempts | integer | Reqiured. Number of attempts. |
| passFail | string | Required. Pass/fail status (e.g. Pass, Fail, Unknown). |

## FifthPathway

Fifth Pathway information.

| Name | Type | Description |
| - | - | - |
| school | [FifthPathwaySchool](#fifthpathwayschool) | Required. School. |
| startDate | string (date) | Required. Start date. |
| endDate | string (date) | Required. End date. |
| certificateDate | string (date) | Required. Certification date. |

## FifthPathwaySchool

Fifth Pathway school. information.

| Name | Type | Description |
| - | - | - |
| name | string | Required. School name. |
| affiliatedInstitution | string | Required. Affiliated institution. |
| city | string | City. |
| stateOrProvince | [Region](#region) | State/province. |

## Identification

Identity information.

| Name | Type | Description |
| - | - | - |
| ssn | string | SSN. |
| ssnLast4 | string | Last 4 of the SSN. |
| npi | string | NPI. |
| usmleId | string | USMLE ID. |
| isUSCitizen | string | US citizen indicator. |
| birthDate | string (date) | Required. Date of birth. |
| birthCity | string | Required. Date of birth. |
| birthStateOrProvince | [Region](#region) | State/province of birth. |
| gender | string | Required. Gender. |

## License

License information.

| Name | Type | Description |
| - | - | - |
| licenseType | string | Type of license. |
| licensingEntity | [CodedDescription](#codeddescription) | Entity issuing license. |
| status | string | License status. |
| practitionerType | [CodedDescription](#codeddescription) | Practitioner type. |
| licenseNumber | string | License number. |
| issueDate | string (date) | Issue date. |
| expirationDate | string (date) | Expiration date. |

## Malpractice

Malpractice Information.

| Name | Type | Description |
| - | - | - |
| state | [CodedDescription](#codeddescription) | Required. State/province of malpractice. |
| eventDate | string (date) | Required. Date of event. |
| patientName | string | Required. Name of patient. |
| courtName | string | Required. Name of court. |
| caseNumber | string | Case number. |
| role | string | Required. Role of practitioner in claim. |
| lawsuiteDate | string (date) | Required. Date of lawsuit. |
| claimStatus | string | Required. Status of claim. |
| insuranceName | string | Required. Name of insurance. |
| judgementAmount | number | Amount of judgement. |
| behalfAmount | number | Behalf amount. |
| explanation | string | Required. Explanation. |
        
## MedicalEducation

Medical school education.

| Name | Type | Description |
| - | - | - |
| school | [School](#school) | Medical school. |
| beginDate | string (date) | Required. Start date. |
| endDate | string (date) | Required. End date. |
| degree | [CodedDescription](#codeddescription) | Degree information. |
| graduationDate | string (date) | Graduation date. |

## MedicalEducationTraining

Medical education.

| Name | Type | Description |
| - | - | - |
| graduating | [MedicalEducation](#medicaleducation) | Graduating school. |
| other | [MedicalEducation[]](#medicaleducation) | Other medical schools. |
| ecfmg | [Ecfmg](#ecfmg) | ECFMG information. |
| fifthPathway | [FifthPathway](#fifthpathway) | 5th Pathway information. |

# Name

Name of a person.

| Name | Type | Description |
| - | - | - |
| firstName | string | Required. First name. |
| middleName | string | Middle name. |
| lastName | string | Required. Last name. |
| suffix | string | Suffix. |

## Names

Names information.

| Name | Type | Description |
| - | - | - |
| legalName | [Name](#name) | Required. Legal name. |
| other | [Name[]](#name) | Other names. |

# OtherTraining

Non-accredited postgraduate training.

| Name | Type | Description |
| - | - | - |
| program | [Program](#program) | Required. Program. |
| specialty | [Specialty](#specialty) | Required. Specialty. |
| programType | string | Required. Program type. |
| trainingStatus | string | Required. Training status. |
| beginDate | string (date) | Required. Start date. |
| endDate | string (date) | Required. End date. |
| percentageClinical | integer | Percentage of training that was Clinical. |
| percentageAdministrative | integer | Percentage of training that was Administrative. |

## Phone

Phone number.

| Name | Type | Description |
| - | - | - |
| phoneType | string | Required. Type of home (e.g. Business, Home, Mobile). |
| phoneNumber | string | Required. Phone number. |
| extension | string | Phone extension. |

## Phones

Phone information.

| Name | Type | Description |
| - | - | - |
| forPublic | [Phone](#phone) | Public phone. |
| forBoard | [Phone](#phone) | Board phone. |
| other | [Phone[]](#phone) | Other phone numbers. |

## PostGraduateTraining

| Name | Type | Description |
| - | - | - |
| accreditedTraining | [AccreditedTraining[]](#accreditedtraining) | Accredited training. |
| otherTraining | [OtherTraining[]](#otherTraining) | Other training. |

## Program

Postgraduate training program.

| Name | Type | Description |
| - | - | - |
| hospitalName | string | Required. Hospital name. |
| affiliatedInstitution | string | Affiliated institution. |
| city | string | Required. City. |
| stateOrProvince | [Region](#region) | State/province. |

## Region

Geographic region.

| Name | Type | Description |
| - | - | - |
| code | string | Required. Region code. |
| description | string | Required. Description. |
| countryCode | string | ISO country code. |
| countryDescription | string | Country description. |

## School

Medical school.

| Name | Type | Description |
| - | - | - |
| name | string | Required. School name. |
| cibisCode | string | CIBIS code. |
| schoolType | [CodedDescription](#codeddescription) | Required. Type of school. |
| city | string | City. |
| stateOrProvince | [Region](#region) | State/province. |

## Specialty

Training specialty.

| Name | Type | Description |
| - | - | - |
| description | string | Required. Description. |
