# ScenePost

**Properties**

| Name        | Type               | Required | Description                                                                          |
| :---------- | :----------------- | :------- | :----------------------------------------------------------------------------------- |
| Actions     | List`<ActionPost>` | ✅       | List of actions to be executed synchronously on recall                               |
| Metadata    | SceneMetadata      | ✅       |                                                                                      |
| Group       | ResourceIdentifier | ✅       |                                                                                      |
| Type\_      | ScenePostType      | ❌       |                                                                                      |
| Palette     | ScenePalette       | ❌       | Group of colors that describe the palette of colors to be used when playing dynamics |
| Speed       | double             | ❌       | Speed of dynamic palette for this scene                                              |
| AutoDynamic | bool               | ❌       | Indicates whether to automatically start the scene dynamically on active recall      |

# ScenePostType

**Properties**

| Name  | Type   | Required | Description |
| :---- | :----- | :------- | :---------- |
| Scene | string | ✅       | "scene"     |

<!-- This file was generated by liblab | https://liblab.com/ -->
