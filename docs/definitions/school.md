# School

Medical school.

| Name | Type | Required | Description |
| - | - | - | - |
| name | string | Yes | School name. |
| cibisCode | string | No | CIBIS code. |
| schoolType | [SchoolType](school-type.md) | Yes | Type of school. |
| city | string | No | City. |
| stateOrProvince | [Region](region.md) | No | State or province. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
