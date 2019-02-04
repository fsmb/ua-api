# Get

Gets the submissions to a board.

```http
GET {baseUrl}/v1/submissions/{board}?fid={fid}&fromDate={fromDate}&toDate={toDate}
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
| 200 | OK | [Submission[]](../definition-submission.md) |

## Security

### Scopes

| Scope | Description |
| -|-|
| ua.read | Grants the ability to read UA information. |

## Examples

### Get All Submissions for a Single Day

Get the submission for 4 Jan 2019.

Input:

```http
GET {baseUrl}/v1/submissions/me?fromDate=01/04/2019&toDate=01/05/2019
```

Output:

```json
```
