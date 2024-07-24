// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace OpenHue.Models;

public record RoomPut(
    /// <value>Type of the supported resources (always `room` here)</value>
    [property:
        JsonPropertyName("type"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Type_ = null,
    /// <value>Child devices/services to group by the derived group</value>
    [property:
        JsonPropertyName("children"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<ResourceIdentifier>? Children = null,
    /// <value>configuration object for a room</value>
    [property:
        JsonPropertyName("metadata"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        RoomPut.RoomPutMetadata? Metadata = null
)
{
    /// <summary>configuration object for a room</summary>
    public record RoomPutMetadata(
        /// <value>Human readable name of a resource</value>
        [property:
            JsonPropertyName("name"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Name = null,
        /// <value>Possible archetypes of a room</value>
        [property:
            JsonPropertyName("archetype"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            RoomArchetype? Archetype = null
    );
}
