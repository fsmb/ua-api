# AmaMedicalSchool

Medical education.

| Name | Type | Required | Description |
| - | - | - | - |
| schoolName | string | Yes | Name of the medical school. |
| educationType | string | No | Type of medical education (Degree or Certificate). |
| graduationYear | string (format: digits, len: 4) | No | Graduation year. |
| graduationDate | string (format: yyyy[-mm]) | No | Graduation year and optionally month. |
| degreeCode | string | No | Degree code (e.g. 'MD', 'DO'). |
| enrollmentDate | string (format: yyyy[-mm]) | No | Enrollment year and optionally month. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
