# Get Current

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

*Note: Output is ellided.*

```json
{
    "id": 1234,
    "fid": "999999940",
    "submitDate": "2019-01-04T16:13:17",
    "application": {
        "licenseType": "MD",
        "boardName": "Texas Medical Board",
        "licenseSubtypeDetails": {
           "code": "FULL"
           "description": "Permanent Medical License"
        }
    },
    "identity": {
        "ssn": "123457777",
        "ssnLast4": "7777",
        "birthDate": "1945-01-06T00:00:00",
        "birthCity": "Seattle",
        "birthStateOrProvince": {
            "code": "WA",
            "description": "Washington",
            "countryCode": "US",
            "countryDescription": "United States"
        },
        "gender": "M"
    },
    "names": {
        "legalName": {
            "firstName": "Robert",
            "middleName": "More",
            "lastName": "Finaling-Final",
            "suffix": "Jr"
        }
    },
    "addresses": {
        "forPublic": {
            "addressType": "Home",
            "lines": [
                "741 A Circle",
            ],
            "city": "Midtown",
            "stateOrProvince": {
                "code": "IA",
                "description": "Iowa",
                "countryCode": "US",
                "countryDescription": "United States"
            },
            "postalCode": "12345"
        },
        "forBoard": {
            "addressType": "Home",
            "lines": [
                "741 A Circle",
            ],
            "city": "Midtown",
            "stateOrProvince": {
                "code": "IA",
                "description": "Iowa",
                "countryCode": "US",
                "countryDescription": "United States"
            },
            "postalCode": "12345"
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
            "phoneNumber": "5455555264"
        },
        "forBoard": {
            "phoneType": "Mobile",
            "phoneNumber": "5455555264"
        }
    }
}
```

For more examples go to [samples](/samples/).
