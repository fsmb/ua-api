# Identification

Identity information.

| Name | Type | Required | Description |
| - | - | - | - |
| ssn | string (format: digits, len: 9) | No | SSN. |
| ssnLast4 | string (format: digits, len: 4) | No | Last 4 of the SSN. |
| npi | string (format: digits, len: 10) | No | NPI. |
| usmleId | string (format: digits, len: 8) | No | USMLE ID. |
| isUSCitizen | string (len: 1) | No | US citizen indicator. |
| birthDate | string (date) | Yes | Date of birth. |
| birthCity | string (len: 50) | Yes | Place of birth. |
| birthStateOrProvince | [StateOrProvince](state-or-province.md) | No | State/province of birth. |
| gender | string (len: 1) | Yes | Gender. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
