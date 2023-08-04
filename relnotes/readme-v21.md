# Release 2.1

## What's New

- Server infrastructure upgrade.
- Behavior of `pageSize` has been changed.
- Sample code has been updated. See below.

## Breaking Changes

- In v2.0 it was documented that Graduating Medical School is no longer required. However this change was reverted before release. v2.1 follows the behavior in v2.0 where the graduating medical school is required.
- In previous versions if a client passed a `pageSize` value larger than the maximum size supported by the server then an error was returned. This has been changed to now use whatever the maximum value the server supports. Returned HTTP header links reflect the new value. Calling code should not assume the page size that is returned matches the page size requested.

## Sample Code Changes

The sample code has been updated to fix some issues.

- The `UaClient.AuthenticationAsync` method incorrectly handled an endpoint with a slash on the end. The code has been fixed to properly detect this case.

*Note: .NET 6.0 requires Visual Studio 2022 or higher. If you are using Visual Studio 2019 then you can change the `TargetFrameworks` value in the client project file to use `net5.0` instead.*
