// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using OpenHue.Json;

namespace OpenHue.Models;

/// <summary>Current status of the lamp with dynamics.</summary>
public record SupportedDynamicStatus : ValueEnum<string>
{
    internal SupportedDynamicStatus(string value)
        : base(value) { }

    public SupportedDynamicStatus()
        : base("dynamic_palette") { }

    public static SupportedDynamicStatus DynamicPalette = new("dynamic_palette");
    public static SupportedDynamicStatus None = new("none");
}
