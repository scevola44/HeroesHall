using System.Text.Json.Serialization;

namespace HeroesHall.Core.Entities
{
	public class CharacterClass
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }
		[JsonPropertyName("initial_proficiencies")]
		public List<Check> InitialProficiencies { get; set; }
		[JsonPropertyName("id")]
		public int Id { get; set; }
	}
}

