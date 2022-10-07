# Uniform Application API 

This is the source for technical information for the Uniform Application (UA) API. This API can be used by member boards to retrieve information about UA applications submitted to the board.

To learn more about FSMB APIs refer to the [Getting Started](https://github.com/fsmb/api-docs) guide. To learn more about this API and to begin using it in your code please contact [FSMB](mailto:ua@fsmb.org).

- URL
  - Demo: `https://services-ua-demo.fsmb.org/`
  - Production: `https://services-ua.fsmb.org/`
- Authentication URL `<baseUrl>/connect/token`
- [Postman Collection](https://www.getpostman.com/collections/98586f4987694d146125)
- [OpenAPI Specification](https://services-ua-demo.fsmb.org/_swagger/v1)

[![Run in Postman](https://run.pstmn.io/button.svg)](https://app.getpostman.com/run-collection/98586f4987694d146125?action=collection%2Fimport#?env%5BUA%20(Demo)%5D=W3sia2V5IjoiYmFzZVVybCIsInZhbHVlIjoiaHR0cHM6Ly9zZXJ2aWNlcy11YS1kZW1vLmZzbWIub3JnIiwiZW5hYmxlZCI6dHJ1ZSwic2Vzc2lvblZhbHVlIjoiaHR0cHM6Ly9zZXJ2aWNlcy11YS1kZW1vLmZzbWIub3JnIiwic2Vzc2lvbkluZGV4IjowfSx7ImtleSI6ImJvYXJkIiwidmFsdWUiOiJtZSIsImVuYWJsZWQiOnRydWUsInNlc3Npb25WYWx1ZSI6Im1lIiwic2Vzc2lvbkluZGV4IjoxfSx7ImtleSI6ImFjY2Vzc1Rva2VuIiwidmFsdWUiOiJTRVRfQllfQVVUSEVOVElDQVRJT04iLCJlbmFibGVkIjp0cnVlLCJzZXNzaW9uVmFsdWUiOiJTRVRfQllfQVVUSEVOVElDQVRJT04iLCJzZXNzaW9uSW5kZXgiOjJ9LHsia2V5IjoiY2xpZW50SWQiLCJ2YWx1ZSI6IkRPX05PVF9TRVQiLCJlbmFibGVkIjp0cnVlLCJzZXNzaW9uVmFsdWUiOiJ1c2VyLm10YXlsb3IiLCJzZXNzaW9uSW5kZXgiOjN9LHsia2V5IjoiY2xpZW50U2VjcmV0IiwidmFsdWUiOiJET19OT1RfU0VUIiwiZW5hYmxlZCI6dHJ1ZSwic2Vzc2lvblZhbHVlIjoiMGU3MDUxOTQtODU3ZC00YmYzLWJjYzEtNTU5NDNiMDUxNWRmIiwic2Vzc2lvbkluZGV4Ijo0fV0=)

## Change Log

| Version | Date | Release Notes |
| - | - | - |
| 2.0 | 05 Oct 2022 | [Release Notes](relnotes/readme-v20.md) |
| 1.4 | 03 May 2022 | Added international malpractice. Updated documentation. |
| 1.3 | 20 Jan 2021 | Updated Medical Education Training definition, sample code, and Postman collection|
| 1.2 | 17 Dec 2019 | Updated Urls |
| 1.1 | 11 April 2019 | [Release Notes](relnotes/readme-v11.md) |
| 1.0 | 22 Nov 2016| Initial version |

## Security

### Scopes 

| Scope | Description |
| - | - |
| ua.read | Grants the ability to read UA information. |

## Resources

- [Practitioners](docs/practitioners-v1/readme.md)
- [Submissions](docs/submissions-v1/readme.md)
