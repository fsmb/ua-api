# Get Submission

Gets a submission by its unique ID for the board.

```http
GET {baseUrl}/v1/submissions/{board}/{id}
```

## URI Parameters

| Name | In | Required | Type | Description |
| - |-|-|-|-|
| baseUrl | path | True | string | The API URL. |
| board | path | True | string | The board code or `me`. |
| id | path | True | integer | The ID of the submission. |

## Responses

| Name | Description | Type |
| - |-|-|
| 200 | OK | [Submission](../definition-submission.md) |
| 404 | Not Found | |

## Security

### Scopes

| Scope | Description |
| -|-|
| ua.read | Grants the ability to read UA information. |

## Examples

### Get a Submission

Get the submission for ID 1234.

Input:

```http
GET {baseUrl}/v1/submissions/me/1234
```

Output:

```json
```
