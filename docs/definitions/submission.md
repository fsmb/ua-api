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
| addresses | [MailingAddresses](mailing-addresses.md) | Yes | Mailing addresses. |
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
