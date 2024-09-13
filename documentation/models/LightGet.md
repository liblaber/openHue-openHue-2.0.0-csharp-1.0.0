# LightGet

**Properties**

| Name             | Type                     | Required | Description                                                                    |
| :--------------- | :----------------------- | :------- | :----------------------------------------------------------------------------- |
| Type\_           | string                   | ❌       | Type of the supported resources                                                |
| Id               | string                   | ❌       | Unique identifier representing a specific resource instance                    |
| IdV1             | string                   | ❌       | Clip v1 resource identifier                                                    |
| Owner            | ResourceIdentifier       | ❌       |                                                                                |
| Metadata         | LightGetMetadata         | ❌       | Deprecated, use metadata on device level                                       |
| On               | On                       | ❌       |                                                                                |
| Dimming          | LightGetDimming          | ❌       |                                                                                |
| ColorTemperature | LightGetColorTemperature | ❌       |                                                                                |
| Color            | LightGetColor            | ❌       |                                                                                |
| Dynamics         | LightGetDynamics         | ❌       |                                                                                |
| Alert            | object                   | ❌       | TODO                                                                           |
| Signaling        | LightGetSignaling        | ❌       | Feature containing signaling properties.                                       |
| Mode             | LightGetMode             | ❌       |                                                                                |
| Gradient         | LightGetGradient         | ❌       |                                                                                |
| Effects          | LightGetEffects          | ❌       | Basic feature containing effect properties.                                    |
| TimedEffects     | LightGetTimedEffects     | ❌       | Basic feature containing timed effect properties.                              |
| Powerup          | LightGetPowerup          | ❌       | Feature containing properties to configure powerup behaviour of a lightsource. |

# LightGetMetadata

Deprecated, use metadata on device level

**Properties**

| Name       | Type           | Required | Description                           |
| :--------- | :------------- | :------- | :------------------------------------ |
| Name       | string         | ❌       | Human readable name of a resource     |
| Archetype  | LightArchetype | ❌       | Light archetype                       |
| FixedMired | long           | ❌       | A fixed mired value of the white lamp |

# LightGetDimming

**Properties**

| Name        | Type   | Required | Description                                                                                  |
| :---------- | :----- | :------- | :------------------------------------------------------------------------------------------- |
| Brightness  | double | ❌       | Brightness percentage. value cannot be 0, writing 0 changes it to lowest possible brightness |
| MinDimLevel | double | ❌       | Percentage of the maximum lumen the device outputs on minimum brightness                     |

# LightGetColorTemperature

**Properties**

| Name          | Type        | Required | Description                                                                       |
| :------------ | :---------- | :------- | :-------------------------------------------------------------------------------- |
| Mirek         | long        | ❌       | color temperature in mirek or null when the light color is not in the ct spectrum |
| MirekValid    | bool        | ❌       | Indication whether the value presented in mirek is valid                          |
| MirekSchema\_ | MirekSchema | ❌       |                                                                                   |

# MirekSchema

**Properties**

| Name         | Type | Required | Description                                   |
| :----------- | :--- | :------- | :-------------------------------------------- |
| MirekMinimum | long | ❌       | minimum color temperature this light supports |
| MirekMaximum | long | ❌       | maximum color temperature this light supports |

# LightGetColor

**Properties**

| Name        | Type          | Required | Description                                                                                                                                                                                                                                                               |
| :---------- | :------------ | :------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| Xy          | GamutPosition | ❌       | CIE XY gamut position                                                                                                                                                                                                                                                     |
| Gamut\_     | Gamut         | ❌       | Color gamut of color bulb. Some bulbs do not properly return the Gamut information. In this case this is not present.                                                                                                                                                     |
| GamutType\_ | GamutType     | ❌       | The gammut types supported by hue – A Gamut of early Philips color-only products – B Limited gamut of first Hue color products – C Richer color gamut of Hue white and color ambiance products – other Color gamut of non-hue products with non-hue gamuts resp w/o gamut |

# Gamut

Color gamut of color bulb. Some bulbs do not properly return the Gamut information. In this case this is not present.

**Properties**

| Name  | Type          | Required | Description           |
| :---- | :------------ | :------- | :-------------------- |
| Red   | GamutPosition | ❌       | CIE XY gamut position |
| Green | GamutPosition | ❌       | CIE XY gamut position |
| Blue  | GamutPosition | ❌       | CIE XY gamut position |

# GamutType

The gammut types supported by hue – A Gamut of early Philips color-only products – B Limited gamut of first Hue color products – C Richer color gamut of Hue white and color ambiance products – other Color gamut of non-hue products with non-hue gamuts resp w/o gamut

**Properties**

| Name  | Type   | Required | Description |
| :---- | :----- | :------- | :---------- |
| A     | string | ✅       | "A"         |
| B     | string | ✅       | "B"         |
| C     | string | ✅       | "C"         |
| Other | string | ✅       | "other"     |

# LightGetDynamics

**Properties**

| Name         | Type                           | Required | Description                                                                                                                                                                                                      |
| :----------- | :----------------------------- | :------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Status       | SupportedDynamicStatus         | ❌       | Current status of the lamp with dynamics.                                                                                                                                                                        |
| StatusValues | List`<SupportedDynamicStatus>` | ❌       | Statuses in which a lamp could be when playing dynamics.                                                                                                                                                         |
| Speed        | double                         | ❌       | speed of dynamic palette or effect. The speed is valid for the dynamic palette if the status is dynamic_palette or for the corresponding effect listed in status. In case of status none, the speed is not valid |
| SpeedValid   | bool                           | ❌       | Indicates whether the value presented in speed is valid                                                                                                                                                          |

# LightGetSignaling

Feature containing signaling properties.

**Properties**

| Name         | Type                     | Required | Description                                                                                            |
| :----------- | :----------------------- | :------- | :----------------------------------------------------------------------------------------------------- |
| SignalValues | List`<SupportedSignals>` | ❌       |                                                                                                        |
| EstimatedEnd | long                     | ❌       | Timestamp indicating when the active signal is expected to end. Value is not set if there is no_signal |
| Colors       | List`<Color>`            | ❌       | Colors that were provided for the active effect.                                                       |

# LightGetMode

**Properties**

| Name      | Type   | Required | Description |
| :-------- | :----- | :------- | :---------- |
| Normal    | string | ✅       | "normal"    |
| Streaming | string | ✅       | "streaming" |

# LightGetGradient

**Properties**

| Name          | Type                          | Required | Description                                                                                                                         |
| :------------ | :---------------------------- | :------- | :---------------------------------------------------------------------------------------------------------------------------------- |
| Points        | List`<Color>`                 | ❌       | Collection of gradients points. For control of the gradient points through a PUT a minimum of 2 points need to be provided.         |
| Mode          | SupportedGradientMode         | ❌       | Mode in which the points are currently being deployed. If not provided during PUT/POST it will be defaulted to interpolated_palette |
| PointsCapable | long                          | ❌       | Number of color points that gradient lamp is capable of showing with gradience.                                                     |
| ModeValues    | List`<SupportedGradientMode>` | ❌       | Modes a gradient device can deploy the gradient palette of colors                                                                   |
| PixelCount    | long                          | ❌       | Number of pixels in the device                                                                                                      |

# LightGetEffects

Basic feature containing effect properties.

**Properties**

| Name         | Type                     | Required | Description                                                              |
| :----------- | :----------------------- | :------- | :----------------------------------------------------------------------- |
| Status       | SupportedEffects         | ❌       |                                                                          |
| StatusValues | List`<SupportedEffects>` | ❌       | Possible status values in which a light could be when playing an effect. |
| Effect       | SupportedEffects         | ❌       |                                                                          |
| EffectValues | List`<SupportedEffects>` | ❌       | Possible status values in which a light could be when playing an effect. |

# LightGetTimedEffects

Basic feature containing timed effect properties.

**Properties**

| Name         | Type                          | Required | Description                                                                                                                                                                                                                                                                                                                             |
| :----------- | :---------------------------- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Effect       | SupportedTimedEffects         | ❌       | Current status values the light is in regarding timed effects                                                                                                                                                                                                                                                                           |
| EffectValues | List`<SupportedTimedEffects>` | ❌       | Possible timed effect values you can set in a light                                                                                                                                                                                                                                                                                     |
| Status       | SupportedTimedEffects         | ❌       | Current status values the light is in regarding timed effects                                                                                                                                                                                                                                                                           |
| StatusValues | List`<SupportedTimedEffects>` | ❌       | Possible status values in which a light could be when playing a timed effect.                                                                                                                                                                                                                                                           |
| Duration     | long                          | ❌       | Duration is mandatory when timed effect is set except for no_effect. Resolution decreases for a larger duration. e.g Effects with duration smaller than a minute will be rounded to a resolution of 1s, while effects with duration larger than an hour will be arounded up to a resolution of 300s. Duration has a max of 21600000 ms. |

# LightGetPowerup

Feature containing properties to configure powerup behaviour of a lightsource.

**Properties**

| Name       | Type            | Required | Description                                                                                                                      |
| :--------- | :-------------- | :------- | :------------------------------------------------------------------------------------------------------------------------------- |
| Preset     | PowerupPreset1  | ❌       | When setting the custom preset the additional properties can be set. For all other presets, no other properties can be included. |
| Configured | bool            | ❌       | Indicates if the shown values have been configured in the lightsource.                                                           |
| On         | PowerupOn1      | ❌       |                                                                                                                                  |
| Dimming    | PowerupDimming1 | ❌       |                                                                                                                                  |

# PowerupPreset1

When setting the custom preset the additional properties can be set. For all other presets, no other properties can be included.

**Properties**

| Name        | Type   | Required | Description     |
| :---------- | :----- | :------- | :-------------- |
| Safety      | string | ✅       | "safety"        |
| Powerfail   | string | ✅       | "powerfail"     |
| LastOnState | string | ✅       | "last_on_state" |
| Custom      | string | ✅       | "custom"        |

# PowerupOn1

**Properties**

| Name | Type    | Required | Description                                                                                                                                                                                                                                                                                 |
| :--- | :------ | :------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| Mode | OnMode1 | ❌       | State to activate after powerup. On will use the value specified in the “on” property. When setting mode “on”, the on property must be included. Toggle will alternate between on and off on each subsequent power toggle. Previous will return to the state it was in before powering off. |
| On   | On      | ❌       |                                                                                                                                                                                                                                                                                             |

# OnMode1

State to activate after powerup. On will use the value specified in the “on” property. When setting mode “on”, the on property must be included. Toggle will alternate between on and off on each subsequent power toggle. Previous will return to the state it was in before powering off.

**Properties**

| Name     | Type   | Required | Description |
| :------- | :----- | :------- | :---------- |
| On       | string | ✅       | "on"        |
| Toggle   | string | ✅       | "toggle"    |
| Previous | string | ✅       | "previous"  |

# PowerupDimming1

**Properties**

| Name    | Type          | Required | Description                                                                                                                                                                                                         |
| :------ | :------------ | :------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| Mode    | DimmingMode1  | ❌       | Dimming will set the brightness to the specified value after power up. When setting mode “dimming”, the dimming property must be included. Previous will set brightness to the state it was in before powering off. |
| Dimming | Dimming       | ❌       |                                                                                                                                                                                                                     |
| Color   | DimmingColor1 | ❌       |                                                                                                                                                                                                                     |

# DimmingMode1

Dimming will set the brightness to the specified value after power up. When setting mode “dimming”, the dimming property must be included. Previous will set brightness to the state it was in before powering off.

**Properties**

| Name     | Type   | Required | Description |
| :------- | :----- | :------- | :---------- |
| Dimming  | string | ✅       | "dimming"   |
| Previous | string | ✅       | "previous"  |

# DimmingColor1

**Properties**

| Name             | Type                   | Required | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| :--------------- | :--------------------- | :------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Mode             | ColorMode1             | ❌       | State to activate after powerup. Availability of “color_temperature” and “color” modes depend on the capabilities of the lamp. Colortemperature will set the colortemperature to the specified value after power up. When setting color_temperature, the color_temperature property must be included Color will set the color tot he specified value after power up. When setting color mode, the color property must be included Previous will set color to the state it was in before powering off. |
| ColorTemperature | ColorColorTemperature1 | ❌       |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |

# ColorMode1

State to activate after powerup. Availability of “color_temperature” and “color” modes depend on the capabilities of the lamp. Colortemperature will set the colortemperature to the specified value after power up. When setting color_temperature, the color_temperature property must be included Color will set the color tot he specified value after power up. When setting color mode, the color property must be included Previous will set color to the state it was in before powering off.

**Properties**

| Name             | Type   | Required | Description         |
| :--------------- | :----- | :------- | :------------------ |
| ColorTemperature | string | ✅       | "color_temperature" |
| Color            | string | ✅       | "color"             |
| Previous         | string | ✅       | "previous"          |

# ColorColorTemperature1

**Properties**

| Name  | Type  | Required | Description                                                                       |
| :---- | :---- | :------- | :-------------------------------------------------------------------------------- |
| Mirek | long  | ❌       | color temperature in mirek or null when the light color is not in the ct spectrum |
| Color | Color | ❌       |                                                                                   |

<!-- This file was generated by liblab | https://liblab.com/ -->
