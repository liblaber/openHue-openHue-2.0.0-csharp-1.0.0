# Powerup

Feature containing properties to configure powerup behaviour of a lightsource.

**Properties**

| Name       | Type            | Required | Description                                                                                                                      |
| :--------- | :-------------- | :------- | :------------------------------------------------------------------------------------------------------------------------------- |
| Preset     | PowerupPreset2  | ❌       | When setting the custom preset the additional properties can be set. For all other presets, no other properties can be included. |
| Configured | bool            | ❌       | Indicates if the shown values have been configured in the lightsource.                                                           |
| On         | PowerupOn2      | ❌       |                                                                                                                                  |
| Dimming    | PowerupDimming2 | ❌       |                                                                                                                                  |

# PowerupPreset2

When setting the custom preset the additional properties can be set. For all other presets, no other properties can be included.

**Properties**

| Name        | Type   | Required | Description     |
| :---------- | :----- | :------- | :-------------- |
| Safety      | string | ✅       | "safety"        |
| Powerfail   | string | ✅       | "powerfail"     |
| LastOnState | string | ✅       | "last_on_state" |
| Custom      | string | ✅       | "custom"        |

# PowerupOn2

**Properties**

| Name | Type    | Required | Description                                                                                                                                                                                                                                                                                 |
| :--- | :------ | :------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| Mode | OnMode2 | ❌       | State to activate after powerup. On will use the value specified in the “on” property. When setting mode “on”, the on property must be included. Toggle will alternate between on and off on each subsequent power toggle. Previous will return to the state it was in before powering off. |
| On   | On      | ❌       |                                                                                                                                                                                                                                                                                             |

# OnMode2

State to activate after powerup. On will use the value specified in the “on” property. When setting mode “on”, the on property must be included. Toggle will alternate between on and off on each subsequent power toggle. Previous will return to the state it was in before powering off.

**Properties**

| Name     | Type   | Required | Description |
| :------- | :----- | :------- | :---------- |
| On       | string | ✅       | "on"        |
| Toggle   | string | ✅       | "toggle"    |
| Previous | string | ✅       | "previous"  |

# PowerupDimming2

**Properties**

| Name    | Type          | Required | Description                                                                                                                                                                                                         |
| :------ | :------------ | :------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| Mode    | DimmingMode2  | ❌       | Dimming will set the brightness to the specified value after power up. When setting mode “dimming”, the dimming property must be included. Previous will set brightness to the state it was in before powering off. |
| Dimming | double        | ❌       | Brightness percentage. value cannot be 0, writing 0 changes it to lowest possible brightness                                                                                                                        |
| Color   | DimmingColor2 | ❌       |                                                                                                                                                                                                                     |

# DimmingMode2

Dimming will set the brightness to the specified value after power up. When setting mode “dimming”, the dimming property must be included. Previous will set brightness to the state it was in before powering off.

**Properties**

| Name     | Type   | Required | Description |
| :------- | :----- | :------- | :---------- |
| Dimming  | string | ✅       | "dimming"   |
| Previous | string | ✅       | "previous"  |

# DimmingColor2

**Properties**

| Name             | Type                   | Required | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| :--------------- | :--------------------- | :------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Mode             | ColorMode2             | ❌       | State to activate after powerup. Availability of “color_temperature” and “color” modes depend on the capabilities of the lamp. Colortemperature will set the colortemperature to the specified value after power up. When setting color_temperature, the color_temperature property must be included Color will set the color tot he specified value after power up. When setting color mode, the color property must be included Previous will set color to the state it was in before powering off. |
| ColorTemperature | ColorColorTemperature2 | ❌       |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |

# ColorMode2

State to activate after powerup. Availability of “color_temperature” and “color” modes depend on the capabilities of the lamp. Colortemperature will set the colortemperature to the specified value after power up. When setting color_temperature, the color_temperature property must be included Color will set the color tot he specified value after power up. When setting color mode, the color property must be included Previous will set color to the state it was in before powering off.

**Properties**

| Name             | Type   | Required | Description         |
| :--------------- | :----- | :------- | :------------------ |
| ColorTemperature | string | ✅       | "color_temperature" |
| Color            | string | ✅       | "color"             |
| Previous         | string | ✅       | "previous"          |

# ColorColorTemperature2

**Properties**

| Name  | Type  | Required | Description                                                                       |
| :---- | :---- | :------- | :-------------------------------------------------------------------------------- |
| Mirek | long  | ❌       | color temperature in mirek or null when the light color is not in the ct spectrum |
| Color | Color | ❌       |                                                                                   |

<!-- This file was generated by liblab | https://liblab.com/ -->
