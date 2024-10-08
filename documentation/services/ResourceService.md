# ResourceService

A list of all methods in the `ResourceService` service. Click on the method name to view detailed information about that method.

| Methods                                 | Description                       |
| :-------------------------------------- | :-------------------------------- |
| [GetResourcesAsync](#getresourcesasync) | API to retrieve all API resources |

## GetResourcesAsync

API to retrieve all API resources

- HTTP Method: `GET`
- Endpoint: `/clip/v2/resource`

**Return Type**

`GetResourcesOkResponse`

**Example Usage Code Snippet**

```csharp
using OpenHue;

var client = new OpenHueClient();

var response = await client.Resource.GetResourcesAsync();

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
