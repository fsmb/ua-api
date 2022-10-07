# MailingAddress

Mailing address.

| Name | Type | Required | Description |
| - | - | - | - |
| addressType | string (len: 20) | Yes | Type of address (e.g. `Business`, `Home`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| lines | string[] (len: 100) | Yes | Address lines. |
| city | string (len: 50) | Yes | City. |
| stateOrProvince | [Region](region.md) | Yes | State/province. |
| postalCode | string (len: 9) | Yes | Postal code. |
| zipCode | | | **Deprecated**. Use `postalCode`. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
