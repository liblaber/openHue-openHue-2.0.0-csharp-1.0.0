// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using OpenHue.Json;

namespace OpenHue.Models;

public record SupportedEffects : ValueEnum<string>
{
    internal SupportedEffects(string value)
        : base(value) { }

    public SupportedEffects()
        : base("prism") { }

    public static SupportedEffects Prism = new("prism");
    public static SupportedEffects Opal = new("opal");
    public static SupportedEffects Glisten = new("glisten");
    public static SupportedEffects Sparkle = new("sparkle");
    public static SupportedEffects Fire = new("fire");
    public static SupportedEffects Candle = new("candle");
    public static SupportedEffects NoEffect = new("no_effect");
}
