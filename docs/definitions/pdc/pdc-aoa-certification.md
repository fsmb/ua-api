**Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.**

# PdcAoaCertification

PDC AOA certification.

| Name | Type | Required | Description |
| - | - | - | - |
| AoaId | string (len: 6) | Yes | AOA ID. |
| ReportDate | string (date-time) | Yes | Report date. |
| BoardName | string (len: 100) | Yes | Board name. |
| CertificationName | string (len: 100) | Yes | Certification name. |
| CertificationStatus | string (len: 20) | No | Certification status (e.g. `Active`, `Inactive`, `Retired`, `Deceased`). |
| CertificationType | string (len: 50) | No | Certification type (e.g. `Primary`, `Subspecialty`). |
| IsOccParticipating | boolean | Yes | Is OCC participating. |
| IsOccRequired | boolean | Yes | Is OCC required. |
| CertificationIssueDate | string (date) | No | Certification issue date. |
| CertificationEndDate | string (date) | No | Certification end date. |
| RecertificationIssueDate | string (date) | No | Recertification issue date. |
| RecertificationExpireDate | string (date) | No | Recertification expire date. |
