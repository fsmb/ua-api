# Get

Gets the submissions for a practitioner.

```http
GET {baseUrl}/v1/practitioners/{board}/{fid}?fromDate={fromDate}&toDate={toDate}
```

## URI Parameters

| Name | In | Required | Type | Description |
| - |-|-|-|-|
| baseUrl | path | True | string | The API URL. |
| board | path | True | string | The board code or `me`. |
| fid | path | True | string | The FID of the practitioner. |
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
|ua.read | Grants the ability to read UA information. |

## Examples

### Get All Submissions for a Practitioner

Input:

```http
GET {baseUrl}/v1/practitioners/me/999999949
```

Output:

```json
```

### Get All Submissions for 2018

Input:

```http
GET {baseUrl}/v1/practitioners/me/999999949?fromDate=01/01/2018&toDate=12/31/2018
```

Output:

```json
```
