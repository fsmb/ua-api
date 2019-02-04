# Get Summary

Gets a summary of submissions to a board.

```http
GET {baseUrl}/v1/submissions/{board}/summary?fid={fid}&fromDate={fromDate}&toDate={toDate}
```

## URI Parameters

| Name | In | Required | Type | Description |
| - |-|-|-|-|
| baseUrl | path | True | string | The API URL. |
| board | path | True | string | The board code or `me`. |
| fid | query | False | string | The optional FID of the practitioner to filter by. |
| fromDate | query | False | DateTime | The optional start date for submissions. |
| toDate | query | False | DateTime | The optional end date for submissions.

This resource supports paging and sorting. The following fields can be ordered.

- `Fid`
- `Id`
- `SubmitDate`

## Responses

| Name | Description | Type |
| - |-|-|
| 200 | OK | [SubmissionSummary[]](definition-submissionsummary.md) |

## Security

### Scopes

| Scope | Description |
| -|-|
| ua.read | Grants the ability to read UA information. |

## Examples

### Get a summary of submissions for one day.

Get a summary of the submissions for 4 Jan 2019.

Input:

```http
GET {baseUrl}/v1/submissions/me/summary?fromDate=01/04/2019&toDate=01/05/2019
```

Output:

```json
[
    {
        "id": 123,
        "fid": "999999956",
        "name": {
            "firstName": "Jess",
            "middleName": "Chris",
            "lastName": "Samphone",
            "suffix": ""
        },
        "submitDate": "2018-01-23T16:13:17.98"
    },
    {
        "id": 789,
        "fid": "999999915",
        "name": {
            "firstName": "Philip",
            "middleName": "James",
            "lastName": "Testman",
            "suffix": ""
        },
        "submitDate": "2018-01-04T11:02:58.587"
    }
]
```

For more examples go to [samples](/samples/).
