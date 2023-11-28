using System.Text.Json.Serialization;

namespace HeroesHall.Core.Entities
{
    public class Hero
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("level")]
        public int Level { get; set; }
        [JsonPropertyName("ancestry")]
        public int Ancestry { get; set; }
        [JsonPropertyName("background")]
        public int Background { get; set; }
        [JsonPropertyName("class")]
        public string CharacterClass { get; set; }

        [JsonPropertyName("classFeats")]
        //[JsonConverter(typeof(DictionaryJsonConverter))]
        public Dictionary<int, IList<string>> ClassFeats { get; set; } = new();

        [JsonPropertyName("attributes")]
        public Dictionary<CharacterAttribute, int> Attributes { get; set; } = new();
        [JsonPropertyName("checks")]
        public Checks Checks { get; set; } = new ();
    }

    public class Checks
    {
        [JsonPropertyName("saving_throws")]
        public Dictionary<SavingThrowName, Check> SavingThrows { get; set; }
        [JsonPropertyName("perception")]
        public Check Perception { get; set; }
        [JsonPropertyName("skills")]
        public Dictionary<SkillName, Check> Skills { get; set; }
        [JsonPropertyName("lore_checks")]
        public Dictionary<string, Check> LoreChecks { get; set; }
    }

    public enum SavingThrowName
    {
        Fortitude,
        Reflex,
        Will
    }

    public enum SkillName
    {
        Acrobatics,
        Athletics,
        Diplomacy
    }

    public enum CheckType
    {
        Perception = 1,
        SavingThrow = 2,
        Skill = 3,
        Lore = 4
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

