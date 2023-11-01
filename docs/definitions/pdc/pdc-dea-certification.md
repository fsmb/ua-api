# PdcDeaCertification

PDC DEA certification.

| Name | Type | Required | Description |
| - | - | - | - |
| reportDate | string (date-time) | Yes | Report date. |
| deaNumber | string (len: 9) | Yes | DEA number. |
| expirationDate | string (date) | No | Expiration date. |
| drugSchedules | string (len: 20)| No | Drug schedules. |
| city | string (len: 50) | No | City. |
| state | string (len: 2)| No | State. |
| zipCode | string (len: 9) | No | Zip code. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
