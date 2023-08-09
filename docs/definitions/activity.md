# Activity

Activity information.

| Name | Type | Required | Description |
| - | - | - | - |
| id | string (len: 50) | Yes | ID of the activity. *Note: The ID is only unique for this request.* |
| type | string (len: 100) | Yes | Type of activity. |
| inProgress | boolean | Yes | Is in progress? |
| beginDate | string (date) | Yes | Start date. |
| endDate | string (date) | No | End date. |
| description | string (len: 100) | Yes | Description. |
| addressLines | string[] (len: 100) | No | Address lines. |
| city | string (len: 50) | No | City. |
| stateOrProvince | [StateOrProvince](../state-or-province.md) | No | State/province. |
| postalCode | string (len: 9) | No | Postal code. |
| position | string (len: 100) | No | Position. |
| department | string (len: 100) | No | Department. |
| wasEmployed | boolean | Yes | Was employee? |
| hadStaffPrivileges | boolean | Yes | Had staff privileges? |
| wasAffiliated | boolean | Yes | Was affiliated? |
| percentageClinical | integer | No | % clinical. |
| percentageAdminstrative | integer | No | % administrative. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
