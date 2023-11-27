# Uniform Application API 

The Uniform Application for Licensure (UA) simplifies the licensure process for state boards by providing license portability and eliminating the need for physicians, physician assistants and resident applicants to
re-enter information when applying for licenses in multiple states. [Participating boards](https://www.fsmb.org/uniform-application/ua-participating-boards/) can use the UA API to retrieve information about UA applications
submitted to the board with the goal of facilitating the licensure processes and needs of the board. Click [here](https://www.fsmb.org/uniform-application) for more information.

Refer to the [Getting Started with FSMB APIs](https://github.com/fsmb/api-docs) guide to learn more general information about FSMB APIs, terminology, authentication, FSMB codes and more.
For more information and to begin using this API please contact FSMB [here](mailto:ua@fsmb.org).

*Note: The error response data is returned using Pascal casing instead of the documented camel casing.*

- URL
  - Demo: `https://services-ua-demo.fsmb.org/`
  - Production: `https://services-ua.fsmb.org/`
- Authentication URL `<baseUrl>/connect/token`
- [Postman Workspace](https://www.postman.com/crimson-shadow-2749/workspace/public-fsmb/collection/1384052-4609734f-70a4-485b-8aa5-20819446f9d3?action=share&creator=1384052)
- [OpenAPI Specification](https://services-ua-demo.fsmb.org/_swagger/v1)

[![Run in Postman](https://run.pstmn.io/button.svg)](https://god.gw.postman.com/run-collection/1384052-4609734f-70a4-485b-8aa5-20819446f9d3?action=collection%2Ffork&source=rip_markdown&collection-url=entityId%3D1384052-4609734f-70a4-485b-8aa5-20819446f9d3%26entityType%3Dcollection%26workspaceId%3D58240218-129c-4c2c-a71a-139a2efabdb2#?env%5BUA%20(Demo)%5D=W3sia2V5IjoiYmFzZVVybCIsInZhbHVlIjoiaHR0cHM6Ly9zZXJ2aWNlcy11YS1kZW1vLmZzbWIub3JnIiwiZW5hYmxlZCI6dHJ1ZSwic2Vzc2lvblZhbHVlIjoiaHR0cHM6Ly9zZXJ2aWNlcy11YS1kZW1vLmZzbWIub3JnIiwic2Vzc2lvbkluZGV4IjowfSx7ImtleSI6ImJvYXJkIiwidmFsdWUiOiJtZSIsImVuYWJsZWQiOnRydWUsInNlc3Npb25WYWx1ZSI6Im1lIiwic2Vzc2lvbkluZGV4IjoxfSx7ImtleSI6ImNsaWVudElkIiwidmFsdWUiOiJET19OT1RfU0VUIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6InNlY3JldCIsInNlc3Npb25WYWx1ZSI6IkRPX05PVF9TRVQiLCJzZXNzaW9uSW5kZXgiOjJ9LHsia2V5IjoiY2xpZW50U2VjcmV0IiwidmFsdWUiOiJET19OT1RfU0VUIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6InNlY3JldCIsInNlc3Npb25WYWx1ZSI6IkRPX05PVF9TRVQiLCJzZXNzaW9uSW5kZXgiOjN9XQ==)

## Change Log

| Date | Release Notes |
| - | - |
| 13 Oct 2023 | [Release Notes](relnotes/relnotes-10132023.md) |
| 04 Aug 2023 | [Release Notes](relnotes/readme-v21.md) |
| 05 Oct 2022 | [Release Notes](relnotes/readme-v20.md) |
| 03 May 2022 | Added international malpractice. Updated documentation. |
| 20 Jan 2021 | Updated Medical Education Training definition, sample code, and Postman collection|
| 17 Dec 2019 | Updated Urls |
| 11 Apr 2019 | [Release Notes](relnotes/readme-v11.md) |
| 22 Nov 2016 | Initial version |

## Security

### Scopes 

| Scope | Description |
| - | - |
| ua.read | Grants the ability to read UA information. |

## Resources

- [Practitioners](docs/practitioners-v1/readme.md)
- [Submissions](docs/submissions-v1/readme.md)
