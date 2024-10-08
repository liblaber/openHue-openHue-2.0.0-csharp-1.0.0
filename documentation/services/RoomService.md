# RoomService

A list of all methods in the `RoomService` service. Click on the method name to view detailed information about that method.

| Methods                             | Description                                            |
| :---------------------------------- | :----------------------------------------------------- |
| [GetRoomsAsync](#getroomsasync)     | List all available rooms                               |
| [CreateRoomAsync](#createroomasync) | Create a new room                                      |
| [GetRoomAsync](#getroomasync)       | Get details of a single room from its given `{roomId}` |
| [UpdateRoomAsync](#updateroomasync) | Update a single room from its given `{roomId}`         |
| [DeleteRoomAsync](#deleteroomasync) | Delete a single room from its given `{roomId}`         |

## GetRoomsAsync

List all available rooms

- HTTP Method: `GET`
- Endpoint: `/clip/v2/resource/room`

**Return Type**

`GetRoomsOkResponse`

**Example Usage Code Snippet**

```csharp
using OpenHue;

var client = new OpenHueClient();

var response = await client.Room.GetRoomsAsync();

Console.WriteLine(response);
```

## CreateRoomAsync

Create a new room

- HTTP Method: `POST`
- Endpoint: `/clip/v2/resource/room`

**Parameters**

| Name  | Type    | Required | Description       |
| :---- | :------ | :------- | :---------------- |
| input | RoomPut | ❌       | The request body. |

**Return Type**

`CreateRoomOkResponse`

**Example Usage Code Snippet**

```csharp
using OpenHue;
using OpenHue.Models;

var client = new OpenHueClient();

var input = new RoomPut();

var response = await client.Room.CreateRoomAsync(input);

Console.WriteLine(response);
```

## GetRoomAsync

Get details of a single room from its given `{roomId}`

- HTTP Method: `GET`
- Endpoint: `/clip/v2/resource/room/{roomId}`

**Parameters**

| Name   | Type   | Required | Description    |
| :----- | :----- | :------- | :------------- |
| roomId | string | ✅       | ID of the room |

**Return Type**

`GetRoomOkResponse`

**Example Usage Code Snippet**

```csharp
using OpenHue;

var client = new OpenHueClient();

var response = await client.Room.GetRoomAsync("roomId");

Console.WriteLine(response);
```

## UpdateRoomAsync

Update a single room from its given `{roomId}`

- HTTP Method: `PUT`
- Endpoint: `/clip/v2/resource/room/{roomId}`

**Parameters**

| Name   | Type    | Required | Description       |
| :----- | :------ | :------- | :---------------- |
| input  | RoomPut | ❌       | The request body. |
| roomId | string  | ✅       | ID of the room    |

**Return Type**

`UpdateRoomOkResponse`

**Example Usage Code Snippet**

```csharp
using OpenHue;
using OpenHue.Models;

var client = new OpenHueClient();

var input = new RoomPut();

var response = await client.Room.UpdateRoomAsync(input, "roomId");

Console.WriteLine(response);
```

## DeleteRoomAsync

Delete a single room from its given `{roomId}`

- HTTP Method: `DELETE`
- Endpoint: `/clip/v2/resource/room/{roomId}`

**Parameters**

| Name   | Type   | Required | Description    |
| :----- | :----- | :------- | :------------- |
| roomId | string | ✅       | ID of the room |

**Return Type**

`DeleteRoomOkResponse`

**Example Usage Code Snippet**

```csharp
using OpenHue;

var client = new OpenHueClient();

var response = await client.Room.DeleteRoomAsync("roomId");

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
