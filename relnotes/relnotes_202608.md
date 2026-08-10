# Release August 2026

## What's New

- [Singular Names](#singular-names)
- [Error Reporting](#error-reporting)

## Breaking Changes
The format for reporting errors has changed to align with standard API practices. Refer to [Error Reporting](#error-reporting) for more information.

## Singular Names

Support for singular names has been added to the API for physician names. Physicians who have only a last name are considered to have a singular name. 
To support this the following changes have been made to the physician's [Name](docs/definitions/name.md).

- The `firstName` field is still required. If the physician has a singular name then the field is set to `FNU` which indicates there is no first name.
- A `isSingularName` field has been added to indicate when the name is singular.

Existing clients will continue to behave as before but should consider updating to support singular names.

- If `isSingularName` is set then the `firstName` should be considered empty and not the value specified.
- It is possible that a physician's first name is `FNU`. Therefore clients should not assume that a first name set to this value is a singular name. Use the indicator instead.

## Error Reporting

