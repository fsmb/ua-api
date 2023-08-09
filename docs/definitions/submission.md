# Submission

A submission to a board.

| Name | Type | Required | Description |
| - | - | - | - |
| id | integer | Yes | Submission ID |
| fid | string (format: digits, len: 9) | Yes | FID of practitioner. |
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
| pdcReportStatus | string (len: 20) | Yes | Status of PDC report. Refer to [ReportStatus](report-status.md) for possible values. |
| pdc | [PdcReport](pdc/pdc-report.md) | No | PDC information, if available. |
| ama | [AmaReport](ama/ama-report.md) | No | AMA information, if available. |
| amaReportStatus | string ([AmaReportStatus](ama/ama-report-status.md)) | Yes | Status of AMA report. |
| fcvs | [FcvsProfileReport](fcvs/fcvs-profile-report.md) | No | FCVS profile information, if available. |
| fcvsProfileStatus | string ([FcvsProfileStatus](fcvs/fcvs-profile-status.md)) | Yes | FCVS profile status. |
| addendum | object | No | |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
