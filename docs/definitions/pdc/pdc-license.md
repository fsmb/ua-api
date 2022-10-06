**Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.**

# PdcLicense

PDC license.

| Name | Type | Required | Description |
| - | - | - | - |
| ReportDate | string (date-time) | Yes | Report date. |
| LicenseType | string (len: 100) | No | Type of license. |
| Issuer | [LicenseEntity](../license-entity.md) | Yes | Issuer of license. |
| Status | string (len: 100) | No | License status. |
| LicenseNumber | string (len: 20) | No | License number. |
| IssueDate | string (date) | No | Issue date. |
| ExpirationDate | string (date) | No | Expiration date. |
