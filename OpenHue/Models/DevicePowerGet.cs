// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using OpenHue.Json;

namespace OpenHue.Models;

public record DevicePowerGet(
    /// <value>Type of the supported resources</value>
    [property:
        JsonPropertyName("type"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Type_ = null,
    /// <value>Unique identifier representing a specific resource instance</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    /// <value>Clip v1 resource identifier</value>
    [property:
        JsonPropertyName("id_v1"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? IdV1 = null,
    [property:
        JsonPropertyName("owner"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ResourceIdentifier? Owner = null,
    [property:
        JsonPropertyName("power_state"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        DevicePowerGet.PowerState? PowerState_ = null
)
{
    public record PowerState(
        /// <value>
        /// Status of the power source of a device, only for battery powered devices.
        ///
        /// - `normal` – battery level is sufficient
        /// - `low` – battery level low, some features (e.g. software update) might stop working, please change battery soon
        /// - `critical` – battery level critical, device can fail any moment
        /// </value>
        [property:
            JsonPropertyName("battery_state"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            PowerState.BatteryState? BatteryState_ = null,
        /// <value>The current battery state in percent, only for battery powered devices.</value>
        [property:
            JsonPropertyName("battery_level"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            long? BatteryLevel = null
    )
    {
        /// <summary>
        /// Status of the power source of a device, only for battery powered devices.
        ///
        /// - `normal` – battery level is sufficient
        /// - `low` – battery level low, some features (e.g. software update) might stop working, please change battery soon
        /// - `critical` – battery level critical, device can fail any moment
        /// </summary>
        public record BatteryState : ValueEnum<string>
        {
            internal BatteryState(string value)
                : base(value) { }

            public BatteryState()
                : base("normal") { }

            public static BatteryState Normal = new("normal");
            public static BatteryState Low = new("low");
            public static BatteryState Critical = new("critical");
        }
    }
}
