# PdcMedicalSchool

PDC medical school.

| Name | Type | Required | Description |
| - | - | - | - |
| name | string (len: 100) | Yes | School name. |
| alternateNames | string[] (len: 100) | No | Alternate school names. |
| cibisCode | string (len: 6) | Yes | CIBIS code. |
| schoolType | [SchoolType](../school-type.md) | Yes | Type of school. |
| city | string (len: 50) | No | City. |
| stateOrProvince | [StateOrProvince](../state-or-province.md) | No | State or province. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
