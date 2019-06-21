# Uniform Application API 

This is the source for technical information for the Federation of State Medical Boards' Uniform Application (UA) [REST API](https://en.wikipedia.org/wiki/Representational_state_transfer). 
The UA API can be used by state medical boards (SMBs) to retrieve information about UA applications submitted to the board. 

If you are interested in learning more about this API, using it in your application or accessing the [Postman]( https://www.getpostman.com/) collection,  please contact [FSMB](mailto:ua@fsmb.org).

## Authentication 

The UA API uses OAuth2 credentialing authentication. 

A client id and client secret are necessary for authentication. Contact FSMB for access to a client id and client secret. Using the client id and client secret execute the authentication request. You will receive a bearer token containing the access token. All subsequent requests will require the token as an authentication header. 

After a set period of time the token will expire and it will be necessary to get another token.

For more information regarding OAuth2 go to their [website](https://oauth.net/2/).

## HTTP Status Codes

These are some standard HTTP status codes you can receive in the response of a request

| HTTP Status Code | Description     |
| ---------------- | --------------- |
| 200              | OK              |
| 204              | No Content      |
| 400              | Bad Request     |
| 401              | Unauthorized    |
| 403              | Forbidden       |
| 404              | Not Found       |
| 500              | Server Error    |
| 501              | Not Implemented |

## HTTP Verbs

| HTTP Verb | Does   |
| --------- | ------ |
| GET       | Read   |
| POST      | Insert |
| PUT       | Update/Replace |
| PATCH     | Update/Modify |
| DELETE    | Delete |

## Definitions

FID - Federation ID. A 9 digit number used to access information about a medical professional.

## Resources

- [Submissions](docs/submissions/README.md)
