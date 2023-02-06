namespace HeroesLodge.Core
{
    public class HeroBuilder
    {
        private CharacterItem _character;

        public HeroBuilder(string name)
        {
            _character = new CharacterItem(name);
        }

        public HeroBuilder SetClass(string className)
        {
            var characterClass = new Pf2eRuleItemRepository().LoadClass(className);
            _character.CharacterClass = characterClass;
            return this;
        }

        public CharacterItem Build() => _character;
    }
}
