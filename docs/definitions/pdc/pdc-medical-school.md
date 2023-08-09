# PdcMedicalSchool

PDC medical school.

| Name | Type | Required | Description |
| - | - | - | - |
| Name | string (len: 100) | Yes | School name. |
| AlternateNames | string[] (len: 100) | No | Alternate school names. |
| CibisCode | string (len: 6) | Yes | CIBIS code. |
| SchoolType | [SchoolType](../school-type.md) | Yes | Type of school. |
| City | string (len: 50) | No | City. |
| StateOrProvince | [StateOrProvince](../state-or-province.md) | No | State or province. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
