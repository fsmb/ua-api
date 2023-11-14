# Submission

A submission to a board.

| Name | Type | Required | Description |
| - | - | - | - |
| id | integer | Yes | Submission ID |
| fid | string (format: digits, len: 9) | Yes | FID of practitioner. |
| submitDate | string (date/time) | Yes | Date/time of submission (not in UTC). |
| application | [Application](application.md) | Yes | Application information. |
| identity | [Identification](identification.md) | Yes | Identity information. |
| names | [Names](names.md) | Yes | Names |
| addresses | [MailingAddresses](mailing-addresses.md) | Yes | Mailing addresses. |
| emailAddresses | [EmailAddresses](email-addresses.md) | Yes | Email addresses. |
| phones | [Phones](phones.md) | Yes | Phone numbers. |
| medicalEducation | [MedicalEducationTraining](medical-education-training.md) | No | Medical education. |
| medicalEducationTraining | | | **Deprecated**. Use `medicalEducation`. |
| postGraduateTraining | [PostGraduateTraining](post-graduate-training.md) | No | Postgraduate training. |                    
| exams | [Exam](exam.md)[] | No | Exams. |
| licenses | [License](license.md)[] | No | Licenses. |
| malpractice | [Malpractice](malpractice.md)[] | No | Malpractice information. |
| activities | [Activity](activity.md)[] | No | Chronology of activity. |
| workHistory | | | **Deprecated**. Use `activities`. |
| pdcReportStatus | string (len: 20) | Yes | Status of PDC report. Refer to [ReportStatus](report-status.md) for possible values. |
| pdc | [PdcReport](pdc/pdc-report.md) | No | PDC information, if available. |
| ama | [AmaReport](ama/ama-report.md) | No | AMA information, if available. |
| amaReportStatus | string ([AmaReportStatus](ama/ama-report-status.md)) | Yes | Status of AMA report. |
| fcvsProfile | [FcvsProfileReport](fcvs/fcvs-profile-report.md) | No | FCVS profile report, if available. |
| fcvsProfileStatus | string ([FcvsProfileStatus](fcvs/fcvs-profile-status.md)) | Yes | FCVS profile status. |
| npdbReport | [NpdbReport](npdb/npdb-report.md) | No | NPDB report, if available. |
| npdbReportStatus | string ([NpdbReportStatus](npdb/npdb-report-status.md)) | Yes | NPDB report status. |
| addendum | object | No | |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

## Example

```json
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
    "pdcReportStatus": "Available",
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
    },
    "amaReportStatus": "NotAvailable",
    "fcvsProfileStatus": "NotAvailable",
    "npdbReportStatus": "NotAvailable"
}
```
