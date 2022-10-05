# Release 1.2

## What's New

None.

## Breaking Changes

### Graduating Medical Education No Longer Required

Graduating medical education is no longer a required field for [MedicalEducatingTraining](https://github.com/fsmb/ua-api/blob/master/docs/definitions/medical-education-training.md).
In some cases physicians have not completed medical school before submitting a UA application. In previous versions this resulted in an error when attempting to retrieve the submission.
With this release the submission is now returned but `MedicalEducationTraining.graduating` will be null.
