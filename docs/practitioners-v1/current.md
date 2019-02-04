# Current

Gets the current submission for a practitioner.

```http
GET {baseUrl}/v1/practitioners/{board}/{fid}/current
```

## URI Parameters

| Name | In | Required | Type | Description |
| - |-|-|-|-|
| baseUrl | path | True | string | The API URL. |
| board | path | True | string | The board code or `me`. |
| fid | path | True | string | The FID of the practitioner. |

## Responses

| Name | Description | Type |
| - |-|-|
| 200 | OK | [Submission](definition-submission) |

## Security

### Scopes

| Scope | Description |
| -|-|
|ua.read | Grants the ability to read UA information. |

## Examples

### Get the last submission

Input:

```http
GET {baseUrl}/v1/practitioners/me/999999949/current
```

Output:

```json
```
