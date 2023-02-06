using HeroesLodge.Core.Rules;
using System.Text.Json.Serialization;

namespace HeroesLodge
{
    public class CharacterClass
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }

        [JsonPropertyName("img")]
        public string Img { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("system")]
        public SystemClass SystemClass { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}