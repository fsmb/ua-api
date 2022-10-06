# Submission Summary

Summary of the submissions to a board.

| Name | Type | Required | Description |
| - | - | - | - |
| id | integer | Yes | Submission ID. |
| fid | string (format: digits, len: 9) | Yes | FID of practitioner. |
| name | [Name](name.md) | Yes | Practitioner name. |
| submitDate | string (datetime) | Yes | Data/time of submission (not in UTC). |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
