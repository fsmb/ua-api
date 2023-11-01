# PdcAbmsCertification

PDC ABMS certification.

| Name | Type | Required | Description |
| - | - | - | - |
| reportDate | string (date) | Yes | Report date. |
| boardName | string (len: 100) | Yes | Certifying board. |
| certificateName | string (len: 100) | Yes | Certificate name. |
| meetsMocRequirements | string (len: 20) | No | Meets MOC requirements (e.g. `Yes`, `No`, `Not Required`). |
| isCertified | boolean | Yes | Is certified. |
| certificateStatus | string (len: 100) | No | Status of certificate (e.g. `Active`, `Inactive`, `Expired`). |
| certificateType | string (len: 100) | Yes | Type of certificate (e.g. `General`, `Subspecialty`). |
| certificateDuration | string (len: 20) | Yes | Duration of certificate (e.g. `Lifetime`, `MOC`, `Time Limited`). |
| occurrenceType | string (len: 20) | Yes | Type of occurrence (e.g. `Initial`, `Recertification`, `Designation`). |
| effectiveDate | [PartialDate](/docs/definitions/partial-date.md) | No | Effective date. |
| expirationDate | [PartialDate](/docs/definitions/partial-date.md) | No | Expiration date. |
| reverificationDate | string (date) | No | Reverification date. |
| mocPathwayId | string (len: 2) | No | MOC pathway ID. |
| mocPathwayName | string (len: 100) | No | MOC pathway name. |
| occupationStatus | string (len: 2) | No | Occupation status (e.g. `R`). |
| occupationStatusNotifyYear | string (yyyy) | No | Occupation status notification year. | 

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
