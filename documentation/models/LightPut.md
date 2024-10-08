# LightPut

**Properties**

| Name                  | Type                  | Required | Description                                                                    |
| :-------------------- | :-------------------- | :------- | :----------------------------------------------------------------------------- |
| Type\_                | string                | ❌       | Type of the supported resources (always `light` here)                          |
| On                    | On                    | ❌       |                                                                                |
| Dimming               | Dimming               | ❌       |                                                                                |
| DimmingDelta          | DimmingDelta          | ❌       |                                                                                |
| ColorTemperature      | ColorTemperature      | ❌       |                                                                                |
| ColorTemperatureDelta | ColorTemperatureDelta | ❌       |                                                                                |
| Color                 | Color                 | ❌       |                                                                                |
| Dynamics              | Dynamics              | ❌       |                                                                                |
| Alert                 | Alert                 | ❌       | Joined alert control                                                           |
| Signaling             | Signaling             | ❌       | Feature containing basic signaling properties.                                 |
| Mode                  | LightPutMode          | ❌       |                                                                                |
| Gradient              | Gradient              | ❌       | Basic feature containing gradient properties.                                  |
| Effects               | Effects               | ❌       | Basic feature containing effect properties.                                    |
| TimedEffects          | LightPutTimedEffects  | ❌       | Basic feature containing timed effect properties.                              |
| Powerup               | Powerup               | ❌       | Feature containing properties to configure powerup behaviour of a lightsource. |

# LightPutMode

**Properties**

| Name      | Type   | Required | Description |
| :-------- | :----- | :------- | :---------- |
| Normal    | string | ✅       | "normal"    |
| Streaming | string | ✅       | "streaming" |

# LightPutTimedEffects

Basic feature containing timed effect properties.

**Properties**

| Name     | Type                  | Required | Description                                                                                                                                                                                                                                                                                                                             |
| :------- | :-------------------- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Effect   | SupportedTimedEffects | ❌       | Current status values the light is in regarding timed effects                                                                                                                                                                                                                                                                           |
| Duration | long                  | ❌       | Duration is mandatory when timed effect is set except for no_effect. Resolution decreases for a larger duration. e.g Effects with duration smaller than a minute will be rounded to a resolution of 1s, while effects with duration larger than an hour will be arounded up to a resolution of 300s. Duration has a max of 21600000 ms. |

<!-- This file was generated by liblab | https://liblab.com/ -->
