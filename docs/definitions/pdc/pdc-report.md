# PdcReport

PDC report.

| Name | Type | Required | Description |
| - | - | - | - |
| AsOfDate | string (date-time) | Yes | Date the report was generated. |
| BoardActionStatus | string (len: 20) | Yes | Board action status. One of: `Cleared`, `Alerted` |
| Names | [PdcNames](pdc-names.md) | Yes | Names. |
| BirthDate | [PartialDate](/docs/definitions/partial-date.md) | No | Birth date. |
| MedicalEducation | [PdcMedicalEducation](pdc-medical-education.md) | Yes | Medical education. |
| Licenses | [PdcLicense](pdc-license.md)[] | No | License information. |
| Npi | [PdcNpi](pdc-npi.md)[] | No | NPI information. |
| Abms | [PdcAbms](pdc-abms.md) | No | ABMS information, if available. |
| Aoa | [PdcAoa](pdc-aoa.md) | No | AOA information, if available. |
| Dea | [PdcDea](pdc-dea.md) | No | DEA information, if available. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
