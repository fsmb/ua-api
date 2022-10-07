# Release 2.0

## What's New

- All definitions containing string fields have been updated to include the maximum length of the string.
- `AccreditedTraining.IsAcgme` and `AccreditedTraiing.IsAoa` are no longer deprecated. They can be used to check for these specific accreditation entities instead of looking at `AccreditationType` directly.
- Sample code has been updated. See below.

## Breaking Changes

### Graduating Medical Education No Longer Required

Graduating medical education is no longer a required field for [MedicalEducatingTraining](https://github.com/fsmb/ua-api/blob/master/docs/definitions/medical-education-training.md).
In some cases physicians have not completed medical school before submitting a UA application. In previous versions this resulted in an error when attempting to retrieve the submission.
With this release the submission is now returned but `MedicalEducationTraining.graduating` will be null.

## Sample Code Changes

The sample code has been updated to fix some issues and make it easier to reuse.

- The UA client and models have been moved to a separate class library that can be copied into existing code bases.
- PDC models have been created to expose the PDC data, when it is available.
- The client and models now support both .NET 4.7.2 and .NET 6.0.

*Note: .NET 6.0 requires Visual Studio 2022 or higher. If you are using Visual Studio 2019 then you can change the `TargetFrameworks` value in the client project file to use `net5.0` instead.*
