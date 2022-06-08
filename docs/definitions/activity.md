# Activity

Activity information.

| Name | Type | Required | Description |
| - | - | - | - |
| id | string | Yes | ID of the activity. *Note: The ID is only unique for this request.* |
| type | string | Yes | Type of activity. |
| inProgress | boolean | Yes | Is in progress? |
| beginDate | string (date) | Yes | Start date. |
| endDate | string (date) | No | End date. |
| description | string | Yes | Description. |
| addressLines | string[] | No | Address lines. |
| city | string | No | City. |
| stateOrProvince | [Region](region.md) | No | State/province. |
| postalCode | string | No | Postal code. |
| position | string | No | Position. |
| department | string | No | Department. |
| wasEmployed | boolean | Yes | Was employee? |
| hadStaffPrivileges | boolean | Yes | Had staff privileges? |
| wasAffiliated | boolean | Yes | Was affiliated? |
| percentageClinical | integer | No | % clinical. |
| percentageAdminstrative | integer | No | % administrative. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
