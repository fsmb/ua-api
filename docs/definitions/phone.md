# Phone

Phone number.

| Name | Type | Required | Description |
| - | - | - | - |
| phoneType | string (len: 20) | Yes | Type of home (e.g. `Business`, `Home`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| phoneNumber | string (len: 10) | Yes | Phone number. |
| extension | string (len: 4) | No | Phone extension. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
