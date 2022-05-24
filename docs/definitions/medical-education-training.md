# MedicalEducationTraining

List of medical education.

| Name | Type | Required | Description |
| - | - | - | - |
| isInternationalGraduate | boolean | Yes | Is international graduate? |
| graduating | [MedicalEducation](medical-education.md) | Yes | Graduating school. |
| other | [MedicalEducation](medical-education.md)[] | No | Other medical schools. |
| ecfmg | [Ecfmg](ecfmg.md) | No | ECFMG information. |
| fifthPathway | [FifthPathway](fifth-pathway.md) | No | 5th Pathway information. |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

