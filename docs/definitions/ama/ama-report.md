# AmaReport

AMA report.

| Name | Type | Required | Description |
| - | - | - | - |
| AsOfDate | string (date-time) | Yes | Date the report was generated. |
| id | integer | Yes | AMA unique ID. |
| demographics | [AmaDemographics](ama-demographics.md) | No | Demographics information. |
| medicalSchools | [AmaMedicalSchool[]](ama-medical-school.md) | No | Medical education. |
| medicalTraining | [AmaMedicalTraining[]](ama-medical-training.md) | No | Medical training. |
| npi | [AmaNpi[]](ama-npi.md) | No | NPI information. |
| licenses | [AmaLicense[]](ama-license.md) | No | Medical licenses. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
