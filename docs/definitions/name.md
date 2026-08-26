# Name

Name of a person.

| Name | Type | Required | Description |
| - | - | - | - |
| firstName | string (len: 50) | Yes | First name. If `isSingularName` is true then this field is set to `FNU`. |
| middleName | string (len: 50) | No | Middle name |
| lastName | string (len: 50) | Yes | Last name |
| suffix | string (len: 4) | No | Suffix |
| isSingularName | boolean | Yes | Indicates if this a singular name |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
