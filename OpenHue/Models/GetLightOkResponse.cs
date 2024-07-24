// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace OpenHue.Models;

public record GetLightOkResponse(
    [property:
        JsonPropertyName("errors"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<Error>? Errors = null,
    [property:
        JsonPropertyName("data"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<LightGet>? Data = null
);
