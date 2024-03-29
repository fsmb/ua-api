# Get Summary

Get a summary of the submissions.

```http
GET {baseUrl}/v1/submissions/{board}/summary
```

With optional parameters.

```http
GET {baseUrl}/v1/submissions/{board}/summary?fid={fid}&fromDate={fromDate}&toDate={toDate}
```

## URI Parameters

| Name | In | Required | Type | Description |
| - |-|-|-|-|
| baseUrl | path | True | string | The API URL. |
| board | path | True | string | The board code or `me`. |
| fid | query | False | string | The optional FID of the practitioner to filter by. |
| fromDate | query | False | DateTime (format: `yyyy-mm-dd`) | The optional start date for submissions. |
| toDate | query | False | DateTime (format: `yyyy-mm-dd`) | The optional end date for submissions.

This resource supports [paging and sorting](https://github.com/fsmb/api-docs/blob/master/docs/paging-sorting.md). The following fields can be ordered.

- `Fid`
- `Id`
- `SubmitDate`

*Note: If there are many submissions then the results will be paged.*

## Responses

| Name | Type | Description |
| - |-|-|
| 200 OK | [SubmissionSummary[]](/docs/definitions/submission-summary.md) | Success |
| 204 No Content | | No submissions found | 
| 404 Not Found | | Board code is missing or invalid |

## Security

### Scopes

| Scope | Description |
| -|-|
| ua.read | Grants the ability to read UA information. |

## Examples

[Get Summary Of Submissions For One Day](#get-summary-of-submissions-for-one-day)
***

### Get Summary Of Submissions For One Day

Get a summary of the submissions for 4 Jan 2019.

#### Sample Request

```http
GET {baseUrl}/v1/submissions/me/summary?fromDate=01/04/2019&toDate=01/05/2019
```

#### Sample Response

Status code: 200

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
