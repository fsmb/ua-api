# AmaDemographics

Physician demogragphic information.

| Name | Type | Required | Description |
| - | - | - | - |
| prefix | string | No | Legal name prefix. |
| firstName | string | No | Legal first name. |
| middleName | string | No | Legal middle name. |
| lastName | string | Yes | Legal last name. |
| suffix | string | No | Legal name suffix. |
| birthDate | string (date) | No | Date of birth. |
| deathDate | string (date) | No | Date that physician was confirmed deceased. |
| isStudent | boolean | No | Indicates if the profile is for a medical student. |
| amaMembershipStatus | string | No | Membership status (e.g. 'Member'). |
| degreeCode | string | No | Indicates what degree a physician was licensed as ('MD', 'DO'). |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
