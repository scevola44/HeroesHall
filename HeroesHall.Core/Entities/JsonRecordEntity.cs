using System.Text.Json.Serialization;

namespace HeroesHall.Core.Entities
{
    public abstract class JsonRecordEntity
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}