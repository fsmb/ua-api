# Phone

Phone number.

| Name | Type | Required | Description |
| - | - | - | - |
| phoneType | string | Yes | Type of home (e.g. `Business`, `Home`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| phoneNumber | string | Yes | Phone number. |
| extension | string | No | Phone extension. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
