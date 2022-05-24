**Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.**

# PdcMedicalSchool

PDC medical school.

| Name | Type | Required | Description |
| - | - | - | - |
| Name | string | Yes | School name. |
| AlternateNames | string[] | No | Alternate school names. |
| CibisCode | string | Yes | CIBIS code. |
| SchoolType | [SchoolType](/docs/definitions/school-type.md) | Yes | Type of school. |
| City | string | No | City. |
| StateOrProvince | [Region](/docs/definitions/region.md) | No | State or province. |
