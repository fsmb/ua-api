# PdcReport

PDC report.

| Name | Type | Required | Description |
| - | - | - | - |
| asOfDate | string (date-time) | Yes | Date the report was generated. |
| boardActionStatus | string (len: 20) | Yes | Board action status. One of: `Cleared`, `Alerted` |
| names | [PdcNames](pdc-names.md) | Yes | Names. |
| birthDate | [PartialDate](/docs/definitions/partial-date.md) | No | Birth date. |
| medicalEducation | [PdcMedicalEducation](pdc-medical-education.md) | Yes | Medical education. |
| licenses | [PdcLicense](pdc-license.md)[] | No | License information. |
| npi | [PdcNpi](pdc-npi.md)[] | No | NPI information. |
| abms | [PdcAbms](pdc-abms.md) | No | ABMS information, if available. |
| aoa | [PdcAoa](pdc-aoa.md) | No | AOA information, if available. |
| dea | [PdcDea](pdc-dea.md) | No | DEA information, if available. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
