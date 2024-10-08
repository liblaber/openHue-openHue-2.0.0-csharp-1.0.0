# DeviceGet

**Properties**

| Name        | Type                       | Required | Description                                                        |
| :---------- | :------------------------- | :------- | :----------------------------------------------------------------- |
| Type\_      | DeviceGetType              | ❌       |                                                                    |
| Id          | string                     | ❌       | Unique identifier representing a specific resource instance        |
| IdV1        | string                     | ❌       | Clip v1 resource identifier                                        |
| Owner       | ResourceIdentifier         | ❌       |                                                                    |
| ProductData | ProductData                | ❌       |                                                                    |
| Metadata    | DeviceGetMetadata          | ❌       |                                                                    |
| Usertest    | DeviceGetUsertest          | ❌       |                                                                    |
| Services    | List`<ResourceIdentifier>` | ❌       | References all services providing control and state of the device. |

# DeviceGetType

**Properties**

| Name   | Type   | Required | Description |
| :----- | :----- | :------- | :---------- |
| Device | string | ✅       | "device"    |

# DeviceGetMetadata

**Properties**

| Name      | Type             | Required | Description                                                          |
| :-------- | :--------------- | :------- | :------------------------------------------------------------------- |
| Name      | string           | ❌       | Human readable name of a resource                                    |
| Archetype | ProductArchetype | ❌       | The default archetype given by manufacturer. Can be changed by user. |

# DeviceGetUsertest

**Properties**

| Name     | Type           | Required | Description                                                                                                                                                                                                             |
| :------- | :------------- | :------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Status   | UsertestStatus | ❌       |                                                                                                                                                                                                                         |
| Usertest | bool           | ❌       | Activates or extends user usertest mode of device for 120 seconds. `false` deactivates usertest mode. In usertest mode, devices report changes in state faster and indicate state changes on device LED (if applicable) |

# UsertestStatus

**Properties**

| Name     | Type   | Required | Description |
| :------- | :----- | :------- | :---------- |
| Set      | string | ✅       | "set"       |
| Changing | string | ✅       | "changing"  |

<!-- This file was generated by liblab | https://liblab.com/ -->
