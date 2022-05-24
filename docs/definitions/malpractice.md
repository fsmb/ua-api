# Malpractice

Malpractice Information.

| Name | Type | Required | Description |
| - | - | - | - |
| state | [Region](region.md) | Yes | State/province of malpractice. |
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
