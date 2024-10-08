// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using OpenHue.Json;

namespace OpenHue.Models;

public record BridgePut(
    [property:
        JsonPropertyName("type"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        BridgePut.BridgePutType? Type_ = null
)
{
    public record BridgePutType : ValueEnum<string>
    {
        internal BridgePutType(string value)
            : base(value) { }

        public BridgePutType()
            : base("bridge") { }

        public static BridgePutType Bridge = new("bridge");
    }
}
