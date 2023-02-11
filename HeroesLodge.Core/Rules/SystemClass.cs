using System.Text.Json.Serialization;

namespace HeroesLodge.Core.Rules
{
    public class SystemClass
    {
        [JsonPropertyName("defenses")]
        public Defenses Defenses { get; set; }

        [JsonPropertyName("keyAbility")]
        public KeyAbility KeyAbility { get; set; }
    }

    public class KeyAbility
    {
        [JsonPropertyName("value")]
        public string[] Value { get; set; }
    }
}
