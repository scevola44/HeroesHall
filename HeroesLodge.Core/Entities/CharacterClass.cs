using System.Text.Json.Serialization;
using System.Windows.Markup;

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

        //[JsonProperty("system")]
        //public SystemClass System { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}