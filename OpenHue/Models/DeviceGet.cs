// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using OpenHue.Json;

namespace OpenHue.Models;

public record DeviceGet(
    [property:
        JsonPropertyName("type"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        DeviceGet.DeviceGetType? Type_ = null,
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
        JsonPropertyName("product_data"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ProductData? ProductData = null,
    [property:
        JsonPropertyName("metadata"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        DeviceGet.DeviceGetMetadata? Metadata = null,
    [property:
        JsonPropertyName("usertest"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        DeviceGet.DeviceGetUsertest? Usertest = null,
    /// <value>References all services providing control and state of the device.</value>
    [property:
        JsonPropertyName("services"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<ResourceIdentifier>? Services = null
)
{
    public record DeviceGetType : ValueEnum<string>
    {
        internal DeviceGetType(string value)
            : base(value) { }

        public DeviceGetType()
            : base("device") { }

        public static DeviceGetType Device = new("device");
    }

    public record DeviceGetMetadata(
        /// <value>Human readable name of a resource</value>
        [property:
            JsonPropertyName("name"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Name = null,
        /// <value>The default archetype given by manufacturer. Can be changed by user.</value>
        [property:
            JsonPropertyName("archetype"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            ProductArchetype? Archetype = null
    );

    public record DeviceGetUsertest(
        [property:
            JsonPropertyName("status"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            DeviceGetUsertest.UsertestStatus? Status = null,
        /// <value>
        /// Activates or extends user usertest mode of device for 120 seconds.
        /// `false` deactivates usertest mode.
        /// In usertest mode, devices report changes in state faster and indicate state changes on device LED (if applicable)
        /// </value>
        [property:
            JsonPropertyName("usertest"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            bool? Usertest = null
    )
    {
        public record UsertestStatus : ValueEnum<string>
        {
            internal UsertestStatus(string value)
                : base(value) { }

            public UsertestStatus()
                : base("set") { }

            public static UsertestStatus Set = new("set");
            public static UsertestStatus Changing = new("changing");
        }
    }
}
