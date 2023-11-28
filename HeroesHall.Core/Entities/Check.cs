using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HeroesHall.Core.Entities
{
    public class Check
    {
        [JsonPropertyName("type")]
        public CheckType Type { get; set; }
        [JsonPropertyName("degree")]
        public ProficiencyDegree DegreeOfProficiency { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("specifics")]
        public string? Specifics { get; set; } = string.Empty;
        [JsonPropertyName("notes")]
        public string? Notes { get; set; } = string.Empty;
        [JsonPropertyName("attribute")]
        public CharacterAttribute Attribute { get; set; }
    }
}

