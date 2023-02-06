using System.Text.Json.Serialization;

namespace HeroesLodge.Core.Rules
{
    public class SystemClass
    {
        [JsonPropertyName("defenses")]
        public Defenses Defenses { get; set; }
    }
}
