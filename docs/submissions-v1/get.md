# Get

Get a list of submissions meeting a set of criteria.

```http
GET {baseUrl}/v1/submissions/{board}?fid={fid}&fromDate={fromDate}&toDate={toDate}
```

## URI Parameters

| Name | In | Required | Type | Description |
| - |-|-|-|-|
| baseUrl | path | True | string | The API URL. |
| board | path | True | string | The board code or `me`. |
| fid | query | False | string | The optional FID of the practitioner to filter by. |
| fromDate | query | False | DateTime (format: `yyyy-mm-dd`) | The optional start date for submissions. |
| toDate | query | False | DateTime (format: `yyyy-mm-dd`) | The optional end date for submissions. |

This resource supports paging and sorting. The following fields can be ordered.

- `Fid`
- `Id`
- `SubmitDate`

Note: If there are many submissions then the results will be paged.

## Responses

| Name | Type | Description |
| - |-|-|
| 200 OK | [Submission[]](/docs/definitions/submission.md) | Success |
| 204 No Content | | No submissions found |
| 404 Not Found | | Board code is missing or invalid |

## Security

### Scopes

| Scope | Description |
| -|-|
| ua.read | Grants the ability to read UA information. |

## Examples

[Get All Submissions for a Single Day](#get-all-submissions-for-a-single-day)
***

### Get All Submissions for a Single Day

Get the submission for 4 Jan 2019.

#### Sample Request

```http
GET {baseUrl}/v1/submissions/me?fromDate=01/04/2019&toDate=01/05/2019
```

#### Sample Response

Status code: 200

*Note: Output is elided. Refer to [Submission](/docs/definitions/submission.md) for a complete example.*

```json
[
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
    },
    {
        "id": 5678,
        "fid": "999999956",
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
                "firstName": "Jess",
                "middleName": "Chris",
                "lastName": "Samphone"
            }
        },
        ...
    }
]
```

For more examples go to [samples](/samples/).
