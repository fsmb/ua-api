# Release 2.0

## What's New

- All definitions containing string fields have been updated to include the maximum length of the string.
- `AccreditedTraining.IsAcgme` and `AccreditedTraiing.IsAoa` are no longer deprecated. They can be used to check for these specific accreditation entities instead of looking at `AccreditationType` directly.

## Breaking Changes

### Graduating Medical Education No Longer Required

Graduating medical education is no longer a required field for [MedicalEducatingTraining](https://github.com/fsmb/ua-api/blob/master/docs/definitions/medical-education-training.md).
In some cases physicians have not completed medical school before submitting a UA application. In previous versions this resulted in an error when attempting to retrieve the submission.
With this release the submission is now returned but `MedicalEducationTraining.graduating` will be null.
