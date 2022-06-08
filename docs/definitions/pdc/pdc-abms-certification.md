**Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.**

# PdcAbmsCertification

PDC ABMS certification.

| Name | Type | Required | Description |
| - | - | - | - |
| ReportDate | string (date) | Yes | Report date. |
| BoardName | string | Yes | Certifying board. |
| CertificateName | string | Yes | Certificate name. |
| MeetsMocRequirements | string | Yes | Meets MOC requirements (e.g. `Yes`, `No`, `Not Required`). |
| IsCertified | boolean | Yes | Is certified. |
| CertificateStatus | string | No | Status of certificate (e.g. `Active`, `Inactive`, `Expired`). |
| CertificateType | string | Yes | Type of certificate (e.g. `General`, `Subspecialty`). |
| CertificateDuration | string | Yes | Duration of certificate (e.g. `Lifetime`, `MOC`, `Time Limited`). |
| OccurrenceType | string | Yes | Type of occurrence (e.g. `Initial`, `Recertification`, `Designation`). |
| EffectiveDate | [PartialDate](/docs/definitions/partial-date.md) | No | Effective date. |
| ExpirationDate | [PartialDate](/docs/definitions/partial-date.md) | No | Expiration date. |
| ReverificationDate | string (date) | No | Reverification date. |
| MocPathwayId | string | No | MOC pathway ID. |
| MocPathwayName | string | No | MOC pathway name. |
| OccupationStatus | string | No | Occupation status (e.g. `R`). |
| OccupationStatusNotifyYear | string (yyyy) | No | Occupation status notification year. | 

