# Migrating from the UA Web Service

Migrating from the UA web service to the UA API will require some significant changes to client code. The UA web service was written back when SOAP was the predominant protocol for server to server communication. XML was the defacto format for data transmission. Today [REST APIs](https://github.com/fsmb/api-docs/blob/master/docs/rest.md) are the preferred communication protocol and JSON is the defacto data format. REST is supported in any language and on any platform that supports web browsing and uses the same ports so no additional firewall rules are needed.

The security landscape has also changed. When the UA web service was released SSL and IP address filtering were the normal security practices in combination with a user name and password. Today SSL has been replaced with TLS 1.1 and IP address filtering is mostly useless given the sophisticated hacking technologies available. [OAuth2](https://github.com/fsmb/api-docs/blob/master/docs/authentication.md) has become the authentication protocol for server to server APIs.

The UA API provides the following benefits over the UA web service.

- Works on any platform and with any language that supports HTTP (the web browsing protocol) without the need for complex code or proxies.
- Supports standard HTTP features like consistent responses, server caching and redirects.
- Uses a simple HTTP-based convention for working with clients.
- Uses OAuth2 to allow for "least privilege" access to data.
- Uses JSON which is an easy to read and write data format that is more concise than XML and more flexible.
- Is accessible over the standard HTTP(S) ports so no additional firewall rules are needed.

Refer to the [Getting Started](https://github.com/fsmb/api-docs) documentation on how to get started using FSMB APIs. 

## Getting Available Submissions

In the UA web service a method was provided to get the submissions that had occurred since the last request. This required that clients call the method to retrieve the data. Each new submission was sent back to the caller and it was marked as "read". Subsequent calls to the method would no longer return the submission. There are some issues with this approach.

1. If any errors occurred after the submission was marked as read then the submission would be lost. This would be especially difficult to detect if the failure occurred while sending the submissions back to the client as the client may never have a record of the submissions.
1. Each call to retrieve the submissions potentially changed their state making it hard to test code that called the service since subsequent requests would not return the earlier data.
1. Submission status was shared by all users for the board. If a board needed to run different processes for different submission types then it had to read them all in a single process and then divide the submissions up manually.

The API does not support the concept of a "read" submission. It is up to each client to determine whether a submission has been seen before or not. It is recommended that a client retrieve a summary of submissions for the date range appropriate for the frequency at which the API is called. For example if a client needs to process submissions only once a day then it makes sense to retrieve all submissions in the last 24-36 hours. 

After getting the available submissions a client can compare the submission ID to each submission it has already processed successful in its back end system. The submission ID is guaranteed unique. If processing fails for any reason then the submission can be retrieved the next time and another attempt made to process it. The API does allow retrieving specific submissions by ID if a client needs to retrieve a specific submission during error recovery.

*Note: Clients should not rely on the sequential ordering of submission IDs.*

The web service provided a method for getting all submissions after a given ID. This does not work in the API. Submission IDs are guaranteed unique but not guaranteed to be sequential. It is possible for a lower ID to be returned in subsequent calls to the API. 

## Mapping XML to JSON

The biggest challenge for migrating from the UA web service to the API is mapping the existing XML elements to their JSON equivalent. This section will discuss the general mapping between XML and JSON. Note that not every XML element has a corresponding JSON object. Furthermore the meaning and value of JSON objects may differ from their XML counterparts.


