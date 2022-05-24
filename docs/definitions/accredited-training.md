# AccreditedTraining

Accredited training information.

| Name | Type | Required | Description |
| - | - | - | - |
| accreditationType | string | Yes | The type of accreditation (e.g. `ACMGE`, `AOA`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| programCode | string | Yes | Program code. |
| program | [Program](#program) | Yes | Program. |
| specialty | [Specialty](#specialty) | Yes | Specialty. |
| programType | string | Yes | Program type. |
| trainingStatus | string | Yes | Training status (e.g. `Active`, `Completed`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| beginDate | string (date) | Yes | Start date. |
| endDate | string (date) | Yes | End date. |
| percentageClinical | integer | No | Percentage of training that was Clinical. |
| percentageAdministrative | integer | No | Percentage of training that was Administrative. |
| isAcgme | | | **Deprecated**. Use `accreditationType`. |
| isAoa | | | **Deprecated**. Use `accreditationType`. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*