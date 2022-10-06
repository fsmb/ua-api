**Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.**

# PdcDeaCertification

PDC DEA certification.

| Name | Type | Required | Description |
| - | - | - | - |
| ReportDate | string (date-time) | Yes | Report date. |
| DeaNumber | string (len: 9) | Yes | DEA number. |
| ExpirationDate | string (date) | No | Expiration date. |
| DrugSchedules | string (len: 20)| No | Drug schedules. |
| City | string (len: 50) | No | City. |
| State | string (len: 2)| No | State. |
| ZipCode | string (len: 9) | No | Zip code. |

