# PdcAoaCertification

PDC AOA certification.

| Name | Type | Required | Description |
| - | - | - | - |
| aoaId | string (len: 6) | Yes | AOA ID. |
| reportDate | string (date-time) | Yes | Report date. |
| boardName | string (len: 100) | Yes | Board name. |
| certificationName | string (len: 100) | Yes | Certification name. |
| certificationStatus | string (len: 20) | No | Certification status (e.g. `Active`, `Inactive`, `Retired`, `Deceased`). |
| certificationType | string (len: 50) | No | Certification type (e.g. `Primary`, `Subspecialty`). |
| isOccParticipating | boolean | Yes | Is OCC participating. |
| isOccRequired | boolean | Yes | Is OCC required. |
| certificationIssueDate | string (date) | No | Certification issue date. |
| certificationEndDate | string (date) | No | Certification end date. |
| recertificationIssueDate | string (date) | No | Recertification issue date. |
| recertificationExpireDate | string (date) | No | Recertification expire date. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
