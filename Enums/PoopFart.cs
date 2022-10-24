using System.Text.Json.Serialization;

namespace choreScore.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PoopFart
{
  Poop,
  Fart
}