**Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.**

## PdcReport

PDC report.

| Name | Type | Required | Description |
| - | - | - | - |
| AsOfDate | string (date-time) | Yes | Date the report was generated. |
| BoardActionStatus | string | Yes | Board action status. One of: `Cleared`, `Alerted` |
| Names | [PdcNames](#pdcNames) | Yes | Names. |
| BirthDate | [PartialDate](/docs/definitions/partial-date.md) | No | Birth date. |
| MedicalEducation | [PdcMedicalEducation](#pdcMedicalEducation) | Yes | Medical education. |
| Licenses | [PdcLicense](#pdcLicense)[] | No | License information. |
| Npi | [PdcNpi](#pdcNpi)[] | No | NPI information. |
| Abms | [PdcAbms](#pdcAbms) | No | ABMS information, if available. |
| Aoa | [PdcAoa](#pdcAoa) | No | AOA information, if available. |
| Dea | [PdcDea](#pdcDea) | No | DEA information, if available. |

## PdcAbms

PDC ABMS information.

| Name | Type | Required | Description |
| - | - | - | - |
| Certifications | [PdcAbmsCertification](#pdcAbmsCertification)[] | No | ABMS certifications. |
