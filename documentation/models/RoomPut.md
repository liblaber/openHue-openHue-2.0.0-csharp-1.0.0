# RoomPut

**Properties**

| Name     | Type                       | Required | Description                                          |
| :------- | :------------------------- | :------- | :--------------------------------------------------- |
| Type\_   | string                     | ❌       | Type of the supported resources (always `room` here) |
| Children | List`<ResourceIdentifier>` | ❌       | Child devices/services to group by the derived group |
| Metadata | RoomPutMetadata            | ❌       | configuration object for a room                      |

# RoomPutMetadata

configuration object for a room

**Properties**

| Name      | Type          | Required | Description                       |
| :-------- | :------------ | :------- | :-------------------------------- |
| Name      | string        | ❌       | Human readable name of a resource |
| Archetype | RoomArchetype | ❌       | Possible archetypes of a room     |

<!-- This file was generated by liblab | https://liblab.com/ -->
