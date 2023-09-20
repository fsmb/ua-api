# FcvsProfileReport

FCVS Profile report.

| Name | Type | Required | Description |
| - | - | - | - |
| profileId | integer | Yes | Profile ID |
| profileStatus | string ([FcvsProfileStatus](fcvs-profile-status.md)) | Yes | Profile status |
| profileSubmitDateUtc | string (date-time) | Yes | Date/time the profile was submitted (in UTC) |
| hasBeenSent | boolean | Yes | Determines if the profile has been sent |
| profileSentDateUtc | string (date-time) | No | Date/time the profile was sent (in UTC), if any |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
