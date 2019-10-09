# Submission Summary

Summary of the submissions to a board.

| Name | Type | Description |
| - | - | - |
| id | integer | Required. Submission ID. |
| fid | string (length: 9, format: digits) | Required. FID of practitioner. |
| name | [Name](#name) | Required. Practitioner name. |
| submitDate | string (datetime) | Required. Data/time of submission (not in UTC). |

## Name

Name of a person.

| Name | Type | Description |
| - | - | - |
| firstName | string | Required. First name. |
| middleName | string | Middle name. |
| lastName | string | Required. Last name. |
| suffix | string | Suffix. |
