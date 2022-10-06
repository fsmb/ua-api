# Submission Summary

Summary of the submissions to a board.

| Name | Type | Description |
| - | - | - |
| id | integer | Required. Submission ID. |
| fid | string (format: digits, len: 9) | Required. FID of practitioner. |
| name | [Name](name.md) | Required. Practitioner name. |
| submitDate | string (datetime) | Required. Data/time of submission (not in UTC). |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
