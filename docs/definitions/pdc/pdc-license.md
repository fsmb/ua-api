# PdcLicense

PDC license.

| Name | Type | Required | Description |
| - | - | - | - |
| reportDate | string (date-time) | Yes | Report date. |
| licenseType | string (len: 100) | No | Type of license. |
| issuer | [LicensingEntity](../licensing-entity.md) | Yes | Issuer of license. |
| status | string (len: 100) | No | License status. |
| licenseNumber | string (len: 20) | No | License number. |
| issueDate | string (date) | No | Issue date. |
| expirationDate | string (date) | No | Expiration date. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
