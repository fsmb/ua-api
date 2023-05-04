# AmaLicense

State medical license information.

| Name | Type | Required | Description |
| - | - | - | - |
| licenseNumber | string | Yes | License number. |
| issueDate | string (date) | No | Issue date. |
| expirationDate | string (date) | No | Expiration date. |
| lastReportedDate | string (date) | No | Last reported date. |
| typeDescription | string | No | Type of license (e.g. 'Limited', 'Pending', 'Restricted', 'Temporary', 'Unlimited'). |
| stateDescription | string | No | State issuing the license. |
| degreeCode | string | No | Licensing degree code (e.g. 'MD', 'DO'). |
| licenseStatus | string | No | Status of license (e.g. 'Active', 'Inactive', 'Denied', 'Unknown'). |
| renewalDate | string (date) | No | Renewal date. |
| physicianName | [AmaName](ama-name.md) | No | Physician name. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
