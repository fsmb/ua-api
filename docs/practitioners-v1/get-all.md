# Get All

Get all the submissions for a practitioner.

```HTTP
GET {baseUrl}/v1/practitioners/{board}/{fid}
```

With optional parameters:

```HTTP
GET {baseUrl}/v1/practitioners/{board}/{fid}?fromDate={fromDate}&toDate={toDate}
```

## URI Parameters

| Name | In | Required | Type | Description |
| - |-|-|-|-|
| baseUrl | path | True | string | The API URL. |
| board | path | True | string | The board code or `me`. |
| fid | path | True | string | The practitioner's FID. |
| fromDate | query | False | DateTime | The optional start date for submissions. |
| toDate | query | False | DateTime | The optional end date for submissions.

This resource supports paging and sorting. The following fields can be ordered.

- `Fid`
- `Id`
- `SubmitDate`

*Note: If there are many submissions then the results will be paged.*

## Responses

| Name | Type | Description |
| - |-|-|
| 200 OK | [Submission[]](/docs/definitions/submission.md) | Success
| 204 No Content | | Practitioner has no submissions |
| 404 Not Found | | Board code is missing or invalid |

## Security

### Scopes

| Scope | Description |
| -|-|
|ua.read | Grants the ability to read UA information. |

## Examples

[Get All Submissions for a Practitioner](#get-all-submissions-for-a-practitioner)

[Get All Submissions for 2018](#get-all-submissions-for-2018)
***

### Get All Submissions for a Practitioner

#### Sample Request

```HTTP
GET {baseUrl}/v1/practitioners/me/999999949
```

#### Sample Response

Status code: 200

```json
[
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
      },
      "pdcReportStatus": "NotAvailable",
      "amaReportStatus": "NotAvailable",
      "fcvsProfileStatus": "NotAvailable",
      "npdbReportStatus": "NotAvailable"
  },
  {
    "id": 5678,
    "fid": "999999940",
    "submitDate": "2019-01-10T16:13:17",
    "application": {
        "licenseType": "MD",
        "boardName": "Texas Medical Board",
        "licenseSubtypeDetails": {
           "code": "FULL",
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
    },
    "pdcReportStatus": "NotAvailable",
    "amaReportStatus": "NotAvailable",
    "fcvsProfileStatus": "NotAvailable",
    "npdbReportStatus": "NotAvailable"
  }
]
```

### Get All Submissions for 2018

#### Sample Request

```http
GET {baseUrl}/v1/practitioners/me/999999949?fromDate=01/01/2018&toDate=12/31/2018
```

#### Sample Response

Status code: 200

```json
[
  {
      "id": 1234,
      "fid": "999999940",
      "submitDate": "2018-11-04T16:13:17",
      "application": {
          "licenseType": "MD",
          "boardName": "Texas Medical Board",
          "licenseSubtypeDetails": {
              "code": "FULL",
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
      },
      "pdcReportStatus": "NotAvailable",
      "amaReportStatus": "NotAvailable",
      "fcvsProfileStatus": "NotAvailable",
      "npdbReportStatus": "NotAvailable"
  },
  {
      "id": 1234,
      "fid": "999999915",
      "submitDate": "2018-07-01T16:13:17",
      "application": {
          "licenseType": "MD",
          "boardName": "Texas Medical Board",
          "licenseSubtypeDetails": {
             "code": "FULL",
             "description": "Permanent Medical License"
          }
      },
      "identity": {
          "ssn": "123451111",
          "ssnLast4": "1111",
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
      },
      "pdcReportStatus": "NotAvailable",
      "amaReportStatus": "NotAvailable",
      "fcvsProfileStatus": "NotAvailable",
      "npdbReportStatus": "NotAvailable"
  }
]
```

For more examples go to [samples](/samples/).
