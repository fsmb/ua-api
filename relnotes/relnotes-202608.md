# Release August 2026

## What's New

- [Singular Names](#singular-names)
- [Error Reporting](#error-reporting)
- [Response Changes](#response-changes)

## Breaking Changes

- The format for reporting errors has changed to align with standard API practices. Refer to [Error Reporting](#error-reporting) for more information.
- Some endpoint responses have changed the status code returned to better reflect the error. Refer to [Response Changes](#response-changes) for more information.

## Singular Names

Support for singular names has been added to the API for physician names. Physicians who have only a last name are considered to have a singular name. 
To support this the following changes have been made to the physician's [Name](/docs/definitions/name.md).

- The `firstName` field is still required. If the physician has a singular name then the field is set to `FNU` which indicates there is no first name.
- A `isSingularName` field has been added to indicate when the name is singular.

Existing clients will continue to behave as before but should consider updating to support singular names.

- If `isSingularName` is set then the `firstName` should be considered empty and not the value specified.
- It is possible that a physician's first name is `FNU`. Therefore clients should not assume that a first name set to this value is a singular name. Use the indicator instead.

## Error Reporting

Historically errors from the API have returned an FSMB-specific error object containing the details of the error. The [RFC7807 Problem Details](https://tools.ietf.org/html/rfc7807) format has become the industry standard format for reporting errors and newer FSMB APIs use this format. Additionally some errors triggered by the lower level HTTP runtime would automatically return the `ProblemDetails` format before the API even had a chance to detect it. This causes confusion and requires that clients that need more detailed error information handle two different formats.

To resolve this the API has fully transitioned to the `ProblemDetails` format for error reporting. This ensures consistent error reporting while also making it behave like other APIs. However this breaks any existing code that reads the error object for detailed information. To allow for migration the API returns additional fields as part of the standard `ProblemDetails` format that line up with some of the older fields.

| Legacy Field | New Field | Description |
| - | - | - |
| `Code` | `type` | Provides a unique identifier for the error |
| `Message` | `detail` or `title` | Provides a friendly description of the error |
| `Target` | `instance` | When applicable, the instance/field that the error is for |

Clients should do the following:

- Continue to use the HTTP status code for general error detection and reporting.
- If specific error details are needed, such as why a request was marked as bad, then read the `ProblemDetails` object.
- Any code relying on the older format including the legacy fields mentioned in the table should be migrated to use the new fields as soon as possible.

The legacy fields will be removed in a future update.

## Response Changes

Some endpoints have been adjusted to better reflect the data or error being returned.

- Any endpoint accepting a FID now requires an exact 9-digit value. Previously less than 9 digits were allowed but would return no results, e.g. 404 or 204. Now a 400 status is returned to reflect the invalid data.
- Previously passing an invalid board code to any endpoint resulted in a 404. This was confusing since some endpoints return a 404 when the request is valid but no data is available. With this release an invalid board code will result in an 403 Forbidden error with a message indicating the code is invalid.
