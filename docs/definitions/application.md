# Application

Application information.

| Name | Type | Required | Description |
| - | - | - | - |
| licenseType | string (len: 5) | Yes | Type of license (e.g. `MD`, `DO`, `PA`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| boardName | string (len: 100) | Yes | Board name. |
| licenseSubtypeDetails | [LicenseSubtype](license-subtype.md) | Yes | Subtype of license. |
| licenseSubtype | string | | **Deprecated**. Use `licenseSubtypeDetails`. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
