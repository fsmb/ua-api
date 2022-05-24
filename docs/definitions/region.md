# Region

Geographic region.

| Name | Type | Required | Description |
| - | - | - | - |
| code | string | Yes | Region code (e.g. `TX`, `MD`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| description | string | Yes | Description. |
| countryCode | string | No | ISO country code (e.g. `US`, `CA`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| countryDescription | string | No | Country description. |

**Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.**
