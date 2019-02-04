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

## Application

| Name | Type | Description |
| - | - | - |
| licenseType | string | Type of license (e.g. MD, DO, PA). |
| boardName | string | Board name. |
| licenseSubtype | string | Subtype of license (e.g. Permanent Medical License). |

## Identification

| Name | Type | Description |
| - | - | - |

## Names

| Name | Type | Description |
| - | - | - |

## Addresses

| Name | Type | Description |
| - | - | - |

## EmailAddresses

| Name | Type | Description |
| - | - | - |

## Phones

| Name | Type | Description |
| - | - | - |

## MedicalEducationTraining

| Name | Type | Description |
| - | - | - |

## PostGraduateTraining

| Name | Type | Description |
| - | - | - |

## Exam

| Name | Type | Description |
| - | - | - |

## License

| Name | Type | Description |
| - | - | - |

## Malpractice

| Name | Type | Description |
| - | - | - |

## Activity

| Name | Type | Description |
| - | - | - |
