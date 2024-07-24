# OpenHue C# SDK 1.0.0

Welcome to the OpenHue SDK documentation. This guide will help you get started with integrating and using the OpenHue SDK in your project.

## Versions

- API version: `v2`
- SDK version: `1.0.0`

## About the API

See [openhue/openhue-api](https://github.com/openhue/openhue-api)

## Table of Contents

- [Setup & Configuration](#setup--configuration)
  - [Supported Language Versions](#supported-language-versions)
  - [Installation](#installation)
- [Authentication](#authentication)
  - [API Key Authentication](#api-key-authentication)
- [Sample Usage](#sample-usage)
- [Services](#services)
- [Models](#models)
- [License](#license)

# Setup & Configuration

## Supported Language Versions

This SDK is compatible with the following versions: `C# >= .NET 6`

## Installation

To get started with the SDK, we recommend installing using `nuget`:

```bash
dotnet add package OpenHue
```

## Authentication

### API Key Authentication

The open-hue API uses API keys as a form of authentication. An API key is a unique identifier used to authenticate a user, developer, or a program that is calling the API.

#### Setting the API key

When you initialize the SDK, you can set the API key as follows:

```cs
using OpenHue;
using OpenHue.Config;

var config = new OpenHueConfig()
{
	ApiKeyAuth = new ApiKeyAuthConfig("YOUR_API_KEY")
};

var client = new OpenHueClient(config);
```

If you need to set or update the API key after initializing the SDK, you can use:

```cs
client.SetApiKey("YOUR_API_KEY")
```

# Sample Usage

Below is a comprehensive example demonstrating how to authenticate and call a simple endpoint:

```cs
using OpenHue;
using OpenHue.Config;
using Environment = OpenHue.Http.Environment;

var apiKeyConfig = new ApiKeyAuthConfig("YOUR_API_KEY");

var config = new OpenHueConfig
{
  Environment = Environment.Default,
ApiKeyAuth = apiKeyConfig
};

var client = new OpenHueClient(config);

var response = await client.Resource.GetResourcesAsync();

Console.WriteLine(response);

```

## Services

The SDK provides various services to interact with the API.

<details> 
<summary>Below is a list of all available services with links to their detailed documentation:</summary>

| Name                                                                 |
| :------------------------------------------------------------------- |
| [AuthService](documentation/services/AuthService.md)                 |
| [ResourceService](documentation/services/ResourceService.md)         |
| [DeviceService](documentation/services/DeviceService.md)             |
| [DevicePowerService](documentation/services/DevicePowerService.md)   |
| [LightService](documentation/services/LightService.md)               |
| [LightLevelService](documentation/services/LightLevelService.md)     |
| [MotionService](documentation/services/MotionService.md)             |
| [GroupedLightService](documentation/services/GroupedLightService.md) |
| [BridgeService](documentation/services/BridgeService.md)             |
| [BridgeHomeService](documentation/services/BridgeHomeService.md)     |
| [SceneService](documentation/services/SceneService.md)               |
| [RoomService](documentation/services/RoomService.md)                 |
| [ZoneService](documentation/services/ZoneService.md)                 |
| [TemperatureService](documentation/services/TemperatureService.md)   |

</details>

## Models

The SDK includes several models that represent the data structures used in API requests and responses. These models help in organizing and managing the data efficiently.

<details> 
<summary>Below is a list of all available models with links to their detailed documentation:</summary>

| Name                                                                                 | Description                                                                                                                         |
| :----------------------------------------------------------------------------------- | :---------------------------------------------------------------------------------------------------------------------------------- |
| [AuthenticateRequest](documentation/models/AuthenticateRequest.md)                   |                                                                                                                                     |
| [Response\_](documentation/models/Response_.md)                                      |                                                                                                                                     |
| [GetResourcesOkResponse](documentation/models/GetResourcesOkResponse.md)             |                                                                                                                                     |
| [GetDevicesOkResponse](documentation/models/GetDevicesOkResponse.md)                 |                                                                                                                                     |
| [GetDeviceOkResponse](documentation/models/GetDeviceOkResponse.md)                   |                                                                                                                                     |
| [DevicePut](documentation/models/DevicePut.md)                                       |                                                                                                                                     |
| [UpdateDeviceOkResponse](documentation/models/UpdateDeviceOkResponse.md)             |                                                                                                                                     |
| [DeleteDeviceOkResponse](documentation/models/DeleteDeviceOkResponse.md)             |                                                                                                                                     |
| [GetDevicePowersOkResponse](documentation/models/GetDevicePowersOkResponse.md)       |                                                                                                                                     |
| [GetDevicePowerOkResponse](documentation/models/GetDevicePowerOkResponse.md)         |                                                                                                                                     |
| [GetLightsOkResponse](documentation/models/GetLightsOkResponse.md)                   |                                                                                                                                     |
| [GetLightOkResponse](documentation/models/GetLightOkResponse.md)                     |                                                                                                                                     |
| [LightPut](documentation/models/LightPut.md)                                         |                                                                                                                                     |
| [UpdateLightOkResponse](documentation/models/UpdateLightOkResponse.md)               |                                                                                                                                     |
| [GetLightLevelsOkResponse](documentation/models/GetLightLevelsOkResponse.md)         |                                                                                                                                     |
| [GetLightLevelOkResponse](documentation/models/GetLightLevelOkResponse.md)           |                                                                                                                                     |
| [LightLevelPut](documentation/models/LightLevelPut.md)                               |                                                                                                                                     |
| [UpdateLightLevelOkResponse](documentation/models/UpdateLightLevelOkResponse.md)     |                                                                                                                                     |
| [GetMotionSensorsOkResponse](documentation/models/GetMotionSensorsOkResponse.md)     |                                                                                                                                     |
| [GetMotionSensorOkResponse](documentation/models/GetMotionSensorOkResponse.md)       |                                                                                                                                     |
| [MotionPut](documentation/models/MotionPut.md)                                       |                                                                                                                                     |
| [UpdateMotionSensorOkResponse](documentation/models/UpdateMotionSensorOkResponse.md) |                                                                                                                                     |
| [GetGroupedLightsOkResponse](documentation/models/GetGroupedLightsOkResponse.md)     |                                                                                                                                     |
| [GetGroupedLightOkResponse](documentation/models/GetGroupedLightOkResponse.md)       |                                                                                                                                     |
| [GroupedLightPut](documentation/models/GroupedLightPut.md)                           |                                                                                                                                     |
| [UpdateGroupedLightOkResponse](documentation/models/UpdateGroupedLightOkResponse.md) |                                                                                                                                     |
| [GetBridgesOkResponse](documentation/models/GetBridgesOkResponse.md)                 |                                                                                                                                     |
| [GetBridgeOkResponse](documentation/models/GetBridgeOkResponse.md)                   |                                                                                                                                     |
| [BridgePut](documentation/models/BridgePut.md)                                       |                                                                                                                                     |
| [UpdateBridgeOkResponse](documentation/models/UpdateBridgeOkResponse.md)             |                                                                                                                                     |
| [GetBridgeHomesOkResponse](documentation/models/GetBridgeHomesOkResponse.md)         |                                                                                                                                     |
| [GetBridgeHomeOkResponse](documentation/models/GetBridgeHomeOkResponse.md)           |                                                                                                                                     |
| [GetScenesOkResponse](documentation/models/GetScenesOkResponse.md)                   |                                                                                                                                     |
| [ScenePost](documentation/models/ScenePost.md)                                       |                                                                                                                                     |
| [CreateSceneOkResponse](documentation/models/CreateSceneOkResponse.md)               |                                                                                                                                     |
| [GetSceneOkResponse](documentation/models/GetSceneOkResponse.md)                     |                                                                                                                                     |
| [ScenePut](documentation/models/ScenePut.md)                                         |                                                                                                                                     |
| [UpdateSceneOkResponse](documentation/models/UpdateSceneOkResponse.md)               |                                                                                                                                     |
| [DeleteSceneOkResponse](documentation/models/DeleteSceneOkResponse.md)               |                                                                                                                                     |
| [GetRoomsOkResponse](documentation/models/GetRoomsOkResponse.md)                     |                                                                                                                                     |
| [RoomPut](documentation/models/RoomPut.md)                                           |                                                                                                                                     |
| [CreateRoomOkResponse](documentation/models/CreateRoomOkResponse.md)                 |                                                                                                                                     |
| [GetRoomOkResponse](documentation/models/GetRoomOkResponse.md)                       |                                                                                                                                     |
| [UpdateRoomOkResponse](documentation/models/UpdateRoomOkResponse.md)                 |                                                                                                                                     |
| [DeleteRoomOkResponse](documentation/models/DeleteRoomOkResponse.md)                 |                                                                                                                                     |
| [GetZonesOkResponse](documentation/models/GetZonesOkResponse.md)                     |                                                                                                                                     |
| [CreateZoneOkResponse](documentation/models/CreateZoneOkResponse.md)                 |                                                                                                                                     |
| [GetZoneOkResponse](documentation/models/GetZoneOkResponse.md)                       |                                                                                                                                     |
| [UpdateZoneOkResponse](documentation/models/UpdateZoneOkResponse.md)                 |                                                                                                                                     |
| [DeleteZoneOkResponse](documentation/models/DeleteZoneOkResponse.md)                 |                                                                                                                                     |
| [GetTemperaturesOkResponse](documentation/models/GetTemperaturesOkResponse.md)       |                                                                                                                                     |
| [GetTemperatureOkResponse](documentation/models/GetTemperatureOkResponse.md)         |                                                                                                                                     |
| [TemperaturePut](documentation/models/TemperaturePut.md)                             |                                                                                                                                     |
| [UpdateTemperatureOkResponse](documentation/models/UpdateTemperatureOkResponse.md)   |                                                                                                                                     |
| [Error](documentation/models/Error.md)                                               |                                                                                                                                     |
| [ResourceGet](documentation/models/ResourceGet.md)                                   |                                                                                                                                     |
| [ResourceIdentifier](documentation/models/ResourceIdentifier.md)                     |                                                                                                                                     |
| [DeviceGet](documentation/models/DeviceGet.md)                                       |                                                                                                                                     |
| [ProductData](documentation/models/ProductData.md)                                   |                                                                                                                                     |
| [ProductArchetype](documentation/models/ProductArchetype.md)                         | The default archetype given by manufacturer. Can be changed by user.                                                                |
| [DevicePowerGet](documentation/models/DevicePowerGet.md)                             |                                                                                                                                     |
| [LightGet](documentation/models/LightGet.md)                                         |                                                                                                                                     |
| [On](documentation/models/On.md)                                                     |                                                                                                                                     |
| [LightArchetype](documentation/models/LightArchetype.md)                             | Light archetype                                                                                                                     |
| [GamutPosition](documentation/models/GamutPosition.md)                               | CIE XY gamut position                                                                                                               |
| [SupportedDynamicStatus](documentation/models/SupportedDynamicStatus.md)             | Current status of the lamp with dynamics.                                                                                           |
| [SupportedSignals](documentation/models/SupportedSignals.md)                         | Indicates which signal is currently active.                                                                                         |
| [Color](documentation/models/Color.md)                                               |                                                                                                                                     |
| [SupportedGradientMode](documentation/models/SupportedGradientMode.md)               | Mode in which the points are currently being deployed. If not provided during PUT/POST it will be defaulted to interpolated_palette |
| [SupportedEffects](documentation/models/SupportedEffects.md)                         |                                                                                                                                     |
| [SupportedTimedEffects](documentation/models/SupportedTimedEffects.md)               | Current status values the light is in regarding timed effects                                                                       |
| [Dimming](documentation/models/Dimming.md)                                           |                                                                                                                                     |
| [DimmingDelta](documentation/models/DimmingDelta.md)                                 |                                                                                                                                     |
| [ColorTemperature](documentation/models/ColorTemperature.md)                         |                                                                                                                                     |
| [ColorTemperatureDelta](documentation/models/ColorTemperatureDelta.md)               |                                                                                                                                     |
| [Dynamics](documentation/models/Dynamics.md)                                         |                                                                                                                                     |
| [Alert](documentation/models/Alert.md)                                               | Joined alert control                                                                                                                |
| [Signaling](documentation/models/Signaling.md)                                       | Feature containing basic signaling properties.                                                                                      |
| [Gradient](documentation/models/Gradient.md)                                         | Basic feature containing gradient properties.                                                                                       |
| [Effects](documentation/models/Effects.md)                                           | Basic feature containing effect properties.                                                                                         |
| [Powerup](documentation/models/Powerup.md)                                           | Feature containing properties to configure powerup behaviour of a lightsource.                                                      |
| [LightLevelGet](documentation/models/LightLevelGet.md)                               |                                                                                                                                     |
| [MotionGet](documentation/models/MotionGet.md)                                       |                                                                                                                                     |
| [GroupedLightGet](documentation/models/GroupedLightGet.md)                           |                                                                                                                                     |
| [Dynamics2](documentation/models/Dynamics2.md)                                       |                                                                                                                                     |
| [BridgeGet](documentation/models/BridgeGet.md)                                       |                                                                                                                                     |
| [BridgeHomeGet](documentation/models/BridgeHomeGet.md)                               |                                                                                                                                     |
| [SceneGet](documentation/models/SceneGet.md)                                         |                                                                                                                                     |
| [ActionGet](documentation/models/ActionGet.md)                                       |                                                                                                                                     |
| [SceneMetadata](documentation/models/SceneMetadata.md)                               |                                                                                                                                     |
| [ScenePalette](documentation/models/ScenePalette.md)                                 | Group of colors that describe the palette of colors to be used when playing dynamics                                                |
| [ColorPaletteGet](documentation/models/ColorPaletteGet.md)                           |                                                                                                                                     |
| [ColorTemperaturePalettePost](documentation/models/ColorTemperaturePalettePost.md)   |                                                                                                                                     |
| [ActionPost](documentation/models/ActionPost.md)                                     |                                                                                                                                     |
| [SceneRecall](documentation/models/SceneRecall.md)                                   |                                                                                                                                     |
| [RoomGet](documentation/models/RoomGet.md)                                           |                                                                                                                                     |
| [RoomArchetype](documentation/models/RoomArchetype.md)                               | Possible archetypes of a room                                                                                                       |
| [TemperatureGet](documentation/models/TemperatureGet.md)                             |                                                                                                                                     |

</details>

## License

This SDK is licensed under the MIT License.

See the [LICENSE](LICENSE) file for more details.

<!-- This file was generated by liblab | https://liblab.com/ -->
