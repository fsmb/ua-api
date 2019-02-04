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

Output is ellided.

```json
{
    "id": 1234,
    "fid": "999999915",
    "submitDate": "2018-01-23T16:13:17",
    "application": {
        "licenseType": "MD",
        "boardName": "Texas Medical Board",
        "licenseSubtype": "Permanent Medical License"
    },
    "identity": {
        "ssn": "123-45-1111",
        "ssnLast4": "1111",
        "npi": "",
        "isUSCitizen": "Y",
        "birthDate": "1978-08-08T00:00:00",
        "birthCity": "Houston",
        "birthStateOrProvince": {
            "code": "TX",
            "description": "Texas",
            "countryCode": "US",
            "countryDescription": "United States"
        },
        "gender": "M"
    },
    "names": {
        "legalName": {
            "firstName": "Philip",
            "middleName": "James",
            "lastName": "Testman"
        }
    },
    "addresses": {
        "forPublic": {
            "addressType": "Business",
            "lines": [
                "9665 Greenway Trail",
            ],
            "city": "Portland",
            "stateOrProvince": {
                "code": "OR",
                "description": "Oregon",
                "countryCode": "US",
                "countryDescription": "United States"
            },
            "postalCode": "89456"
        },
        "forBoard": {
            "addressType": "Business",
            "lines": [
                "9665 Greenway Trail",
            ],
            "city": "Portland",
            "stateOrProvince": {
                "code": "OR",
                "description": "Oregon",
                "countryCode": "US",
                "countryDescription": "United States"
            },
            "postalCode": "89456"
        }
    },
    "emailAddresses": {
        "forPublic": {
            "email": "noreply@fsmb.org"
        },
        "forBoard": {
            "email": "noreply@fsmb.org"
        }
    },
    "phones": {
        "forPublic": {
            "phoneType": "Business",
            "phoneNumber": "8524567856"
        },
        "forBoard": {
            "phoneType": "Mobile",
            "phoneNumber": "8524567856"
        }
    }
}
```
