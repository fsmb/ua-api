# NpdbReport

NPDB report.

The NPDB report is only available if a physician submits an FCVS application to the board and the board has authorized FSMB to query NPDB on their behalf.

| Name | Type | Required | Description |
| - | - | - | - |
| asOfDate | string (date-time) | Yes | Date the report was generated. |
| availableReports | [NpdbReportType[]](npdb-report-type.md) | No | List of available reports, if any. |
| hasAvailableReports | boolean | Yes | Are reports available? |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
