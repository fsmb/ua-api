# AmaNpi

NPI information.

| Name | Type | Required | Description |
| - | - | - | - |
| npiNumber | string (format: digits, len: 10) | Yes | NPI number. |
| deactivationDate | string (date) | NO | Date the number was deactivated. |
| reactivationDate | string (date) | No | Date the number was reactivated. |
| replacementNpiNumber | string (format: digits, len: 10) | No | Replacement NPI number. |
| lastReportedDate | string (date) | No | Last reported date. |
| endDate | string (date) | No | End date. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
