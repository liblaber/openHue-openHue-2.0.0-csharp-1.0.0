// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace OpenHue.Models;

public record ColorTemperature(
    /// <value>color temperature in mirek or null when the light color is not in the ct spectrum</value>
    [property:
        JsonPropertyName("mirek"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Mirek = null
);
