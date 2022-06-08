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
      "pdc": {
         "asOfDate": "2019-01-04T12:34:56",
           "boardActionStatus": "Alerted",
            "names": {
                "legal": {
                    "firstName": "Philip",
                    "middleName": "James",
                    "lastName": "Testman",
                    "suffix": ""
                },
                "other": []
            },
            "birthDate": {
                "month": "08",
                "day": "08",
                "year": "1978",
                "date": "1978-08-08T00:00:00"
            },
            "medicalEducation": {
                "school": {
                    "name": "West Virginia University School of Medicine",
                    "alternateNames": [],
                    "schoolType": {
                        "code": "MD",
                        "description": "Doctor of Medicine"
                    },
                    "city": "Morgantown",
                    "stateOrProvince": {
                        "code": "WV",
                        "description": "West Virginia",
                        "countryDescription": "UNITED STATES"
                    }
                },
                "graduationDate": {
                    "year": "2004"
                },
                "degree": {
                    "code": "MD",
                    "description": "Doctor of Medicine"
                }
            },
            "licenses": [
                {
                    "reportDate": "2011-11-11T00:00:00",
                    "licenseType": "Administrative",
                    "issuer": {
                        "code": "ALABAMA",
                        "description": "Alabama State Board of Medical Examiners"
                    },
                    "status": "Active",
                    "licenseNumber": "TEST1111",
                    "issueDate": "2010-07-01T00:00:00",
                    "expirationDate": "2020-06-30T00:00:00"
                },
                {
                    "reportDate": "2011-11-11T00:00:00",
                    "licenseType": "Teaching",
                    "issuer": {
                        "code": "ALASKA",
                        "description": "Alaska State Medical Board"
                    },
                    "status": "Expired",
                    "licenseNumber": "TEST2222",
                    "issueDate": "2001-07-01T00:00:00",
                    "expirationDate": "2012-06-30T00:00:00"
                },
                {
                    "reportDate": "2011-11-11T00:00:00",
                    "licenseType": "Full",
                    "issuer": {
                        "code": "ARIZONA",
                        "description": "Arizona Medical Board"
                    },
                    "status": "Expired",
                    "licenseNumber": "TEST3333",
                    "issueDate": "2010-07-01T00:00:00",
                    "expirationDate": "2020-06-30T00:00:00"
                },
                {
                    "reportDate": "2011-11-11T00:00:00",
                    "licenseType": "Full",
                    "issuer": {
                        "code": "NEW HAMPSHIRE",
                        "description": "New Hampshire Board of Medicine"
                    },
                    "status": "Active",
                    "licenseNumber": "TEST555",
                    "issueDate": "2004-07-01T00:00:00",
                    "expirationDate": "2020-06-30T00:00:00"
                }
            ],
            "npi": [],
            "abms": {
                "certifications": []
            },
            "aoa": {
                "certifications": []
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
        "licenseSubtypeDetails": {
           "code": "FULL",
           "description": "Permanent Medical License"
        }
    },
    "identity": {
        "ssn": "123456666",
        "ssnLast4": "6666",
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
