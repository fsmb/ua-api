# Malpractice

Malpractice Information.

| Name | Type | Required | Description |
| - | - | - | - |
| state | [StateOrProvince](../state-or-province.md) | Yes | State/province of malpractice. |
| eventDate | string (date) | Yes | Date of event. |
| patientName | string (len: 100) | Yes | Name of patient. |
| courtName | string (len: 100) | Yes | Name of court. |
| caseNumber | string (len: 50) | No | Case number. |
| role | string (len: 100) | Yes | Role of practitioner in claim. |
| lawsuiteDate | string (date) | Yes | Date of lawsuit. |
| claimStatus | string (len: 100) | Yes | Status of claim. |
| insuranceName | string (len: 100) | Yes | Name of insurance. |
| judgementAmount | number | No | Amount of judgement. |
| behalfAmount | number | No | Behalf amount. |
| explanation | string (len: 2000) | Yes | Explanation. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
