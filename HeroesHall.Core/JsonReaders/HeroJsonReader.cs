using HeroesHall.Core.Entities;

namespace HeroesLodge.Core.JsonReaders
{
    public class HeroJsonReader : GenericJsonReader<Hero>, IHeroJsonReader
    {
        public HeroJsonReader() : base("Heroes") { }
    }

    public interface IHeroJsonReader
    {
        public Hero Load(string heroName);
    }
}

