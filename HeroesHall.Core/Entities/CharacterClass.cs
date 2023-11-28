using System.Text.Json.Serialization;

namespace HeroesHall.Core.Entities
{
	public class CharacterClass
	{
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("aon_id")]
        public int AonId { get; set; }
        [JsonPropertyName("name")]
		public string Name { get; set; }
		[JsonPropertyName("initial_proficiencies_skills")]
		public List<Check> InitialProficienciesSkills { get; set; }
        [JsonPropertyName("initial_proficiencies_lore")]
        public List<Check> InitialProficienciesLore { get; set; }
        [JsonPropertyName("initial_proficiencies_saving_throws")]
        public List<Check> InitialProficienciesSavingThrows { get; set; }
        [JsonPropertyName("initial_proficiencies_perception")]
        public Check InitialProficiencyPerception { get; set; }
	}
}

