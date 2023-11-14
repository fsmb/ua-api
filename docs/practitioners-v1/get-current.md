# Get Current

Get the current submission for a practitioner.

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

| Name | Type | Description |
| - |-|-|
| 200 OK | [Submission](/docs/definitions/submission.md) | Success |
| 204 No Content | | Practitioner has no submissions |
| 404 Not Found | | Board code is missing or invalid |

## Security

### Scopes

| Scope | Description |
| -|-|
|ua.read | Grants the ability to read UA information. |

## Examples

[Get the last submission](#get-the-last-submission)
***

### Get the last submission

#### Sample Request

```http
GET {baseUrl}/v1/practitioners/me/999999949/current
```

#### Sample Response

Status code: 200

*Note: Output is elided. Refer to [Submission](/docs/definitions/submission.md) for a complete example.*

```json
{
    "id": 1234,
    "fid": "999999940",
    "submitDate": "2019-01-04T16:13:17",
    "application": {
        "licenseType": "MD",
        "boardName": "Texas Medical Board",
        "licenseSubtypeDetails": {
           "code": "FULL",
           "description": "Permanent Medical License"
        }
    },
    "names": {
        "legalName": {
            "firstName": "Robert",
            "middleName": "More",
            "lastName": "Finaling-Final",
            "suffix": "Jr"
        }
    },
    ...
}
```

For more examples go to [samples](/samples/).
