# Get Submission

Get a specific submission by its ID.

```HTTP
GET {baseUrl}/v1/submissions/{board}/{id}
```

## URI Parameters

| Name | In | Required | Type | Description |
| - |-|-|-|-|
| baseUrl | path | True | string | The API URL. |
| board | path | True | string | The board code or `me`. |
| id | path | True | integer | The ID of the submission. |

## Responses

| Name | Type | Description |
| - |-|-|
| 200 OK | [Submission](/docs/definitions/submission.md) | Success |
| 404 Not Found | | Board code is missing or invalid, or submission not found. |

## Security

**Security Risk:** When retrieving submissions by ID be sure to first validate the submission ID belongs to the authenticated user when collecting the ID from the user either directly or via a URL. A malicious user could enter random IDs which could potentially be valid for the board resulting in a submission being loaded that is not valid for the user. 

**Example:** A website collects the submission ID for a UA application from the user. A malicious user goes to the site and starts entering IDs, incrementing by 1, until a successful call is made.

**Solution:** Require at least two pieces of information such as the FID and submission ID. Query for the submission using the [Get Submission by Practitioner](/docs/practitioners-v1/get.md) resource that requires both the FID and submission ID. If they do not match then the request will fail. This will make it harder for a malicious user to guess a valid FID or ID.

### Scopes

| Scope | Description |
| -|-|
| ua.read | Grants the ability to read UA information. |

## Examples

[Get a Submission](#get-a-submission)
***

### Get a Submission

Get the submission for ID 1234.

#### Sample Request

```http
GET {baseUrl}/v1/submissions/me/1234
```

#### Sample Response

Status code: 200

*Note: Output is elided. Refer to [Submission](/docs/definitions/submission.md) for a complete example.*

```json
{
    "id": 1234,
    "fid": "999999915",
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
            "firstName": "Philip",
            "middleName": "James",
            "lastName": "Testman"
        }
    },
    ...
}
```

For more examples go to [samples](/samples/).
