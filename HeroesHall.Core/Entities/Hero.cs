

using System.Text.Json.Serialization;

namespace HeroesHall.Core.Entities
{
    public class Hero
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("level")]
        public int Level { get; set; }
        [JsonPropertyName("ancestry")]
        public int Ancestry { get; set; }
        [JsonPropertyName("background")]
        public int Background { get; set; }
        [JsonPropertyName("class")]
        public int CharacterClass { get; set; }

        [JsonPropertyName("classFeats")]
        //[JsonConverter(typeof(DictionaryJsonConverter))]
        public IDictionary<int, IList<string>> ClassFeats { get; set; }
    }

    /*public class DictionaryJsonConverter : JsonConverter
    {
        public override bool CanWrite
        {
            get { return false; }
        }

        public override bool CanConvert(Type objectType)
        {
            return false;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize(reader, objectType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }*/
}

