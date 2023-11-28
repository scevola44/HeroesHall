using HeroesHall.Core.Entities;
using HeroesLodge.Core.JsonReaders;

namespace HeroesHall.Core.JsonReaders
{
	public class CharacterClassJsonReader : GenericJsonReader<CharacterClass>
	{
		public CharacterClassJsonReader() : base("Classes")
		{
		}
	}
}

