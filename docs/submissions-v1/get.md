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

| Name | Type | Description |
| - |-|-|
| 200 OK | [Submission[]](/docs/definitions/submission.md) | Success |

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

*Note: Output is ellided.*

```json
[
  {
      "id": 1234,
      "fid": "999999915",
      "submitDate": "2019-01-04T16:13:17",
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
  },
  {
    "id": 5678,
    "fid": "999999956",
    "submitDate": "2019-01-04T16:13:17",
    "application": {
        "licenseType": "MD",
        "boardName": "Texas Medical Board",
        "licenseSubtype": "Permanent Medical License"
    },
    "identity": {
        "ssn": "123-45-6666",
        "ssnLast4": "6666",
        "npi": "",
        "isUSCitizen": "Y",
        "birthDate": "1965-05-09T00:00:00",
        "birthCity": "Albany",
        "birthStateOrProvince": {
            "code": "NY",
            "description": "New York",
            "countryCode": "US",
            "countryDescription": "United States"
        },
        "gender": "M"
    },
    "names": {
        "legalName": {
            "firstName": "Jess",
            "middleName": "Chris",
            "lastName": "Samphone"
        }
    },
    "addresses": {
        "forPublic": {
            "addressType": "Business",
            "lines": [
                "6547 Skyline Way",
            ],
            "city": "Roanoke",
            "stateOrProvince": {
                "code": "VA",
                "description": "Virginia",
                "countryCode": "US",
                "countryDescription": "United States"
            },
            "postalCode": "45675"
        },
        "forBoard": {
            "addressType": "Business",
            "lines": [
                "6547 Skyline Way",
            ],
            "city": "Roanoke",
            "stateOrProvince": {
                "code": "VA",
                "description": "Virginia",
                "countryCode": "US",
                "countryDescription": "United States"
            },
            "postalCode": "45675"
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
            "phoneNumber": "7418529654"
        },
        "forBoard": {
            "phoneType": "Mobile",
            "phoneNumber": "7418529654"
        }
    }
  }
]
```

For more examples go to [samples](/samples/).
