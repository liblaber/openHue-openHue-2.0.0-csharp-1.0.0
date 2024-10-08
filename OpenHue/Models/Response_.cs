// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace OpenHue.Models;

public record Response_(
    [property:
        JsonPropertyName("success"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        Response_.Success? Success_ = null,
    [property:
        JsonPropertyName("error"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        Response_.ResponseError? Error = null
)
{
    public record Success(
        [property:
            JsonPropertyName("username"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Username = null,
        [property:
            JsonPropertyName("clientkey"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Clientkey = null
    );

    public record ResponseError(
        [property:
            JsonPropertyName("type"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            long? Type_ = null,
        [property:
            JsonPropertyName("address"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Address = null,
        [property:
            JsonPropertyName("description"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Description = null
    );
}
