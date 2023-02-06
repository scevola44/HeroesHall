using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace HeroesLodge.Core.Rules
{
    public class Defenses
    {
        [JsonPropertyName("heavy")]
        public int Heavy { get; set; }

        [JsonPropertyName("light")]
        public int Light { get; set; }

        [JsonPropertyName("medium")]
        public int Medium { get; set; }

        [JsonPropertyName("unarmored")]
        public int Unarmored { get; set; }
    }
}
