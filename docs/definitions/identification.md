# Identification

Identity information.

| Name | Type | Required | Description |
| - | - | - | - |
| ssn | string (length: 9, format: digits) | No | SSN. |
| ssnLast4 | string (length: 4, format: digits) | No | Last 4 of the SSN. |
| npi | string (length: 10, format: digits) | No | NPI. |
| usmleId | string (length: 8, format: digits) | No | USMLE ID. |
| isUSCitizen | string | No | US citizen indicator. |
| birthDate | string (date) | Yes | Date of birth. |
| birthCity | string | Yes | Place of birth. |
| birthStateOrProvince | [Region](region.md) | No | State/province of birth. |
| gender | string | Yes | Gender. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
