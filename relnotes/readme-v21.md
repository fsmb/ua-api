# Release 2.1

## What's New

- Server infrastructure upgrade.
- New endpoint added for getting submission by FID and ID.
- FCVS status, if available, is returned with submissions.
- Behavior of `pageSize` has been changed.
- Sample code has been updated.

## Breaking Changes

- In v2.0 it was documented that Graduating Medical School is no longer required. However this change was reverted before release. v2.1 follows the behavior in v2.0 where the graduating medical school is required.
- In previous versions if a client passed a `pageSize` value larger than the maximum size supported by the server then an error was returned. This has been changed to now use whatever the maximum value the server supports. Returned HTTP header links reflect the new value. Calling code should not assume the page size that is returned matches the page size requested. [33024]

## Practitioner Changes

- Added a new endpoint (`v1/practitioners/me/{fid}/{id}`) to get a specific submission for a FID. This endpoint follows the recommended security guidelines when querying the API based upon user input. It requires two data points to retrieve a submission. It is recommended that clients use this endpoint when using data provided by the end user to avoid accidentally exposing the wrong information. [22579]
 
## Submission Changes

- For FCVS supporting boards the FCVS profile status for a physician is returned as part of the UA submission data. Refer to [Submission](/docs/definitions/submission.md) for more information. [33021]

## Sample Code Changes

The sample code has been updated.

- The `UaClient.AuthenticationAsync` method incorrectly handled an endpoint with a slash on the end. The code has been fixed to properly detect this case. [33024]
- A new menu option to get submissions by FID and ID has been added to demonstrate the new endpoint. [22579]
- Command line processing has been modified to make it easier to override the URL or board being used. [22579]

*Note: .NET 6.0 requires Visual Studio 2022 or higher. If you are using Visual Studio 2019 then you can change the `TargetFrameworks` value in the client project file to use `net5.0` instead.*
