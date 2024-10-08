// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace OpenHue.Models;

/// <summary>Basic feature containing effect properties.</summary>
public record Effects(
    [property:
        JsonPropertyName("effect"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        SupportedEffects? Effect = null
);
