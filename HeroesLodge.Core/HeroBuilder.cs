using HeroesLodge.Core.Rules;

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

        public HeroBuilder SetBoosts(int level, List<Ability> abilityBoosts)
        {
            if (_character.Build.Abilities.BoostsPerLevel.ContainsKey(level)) _character.Build.Abilities.BoostsPerLevel[level] = abilityBoosts;
            else _character.Build.Abilities.BoostsPerLevel.Add(level, abilityBoosts);
           
            _character.Build.Abilities.ReloadAttributes();
            return this;
        }

        public CharacterItem Build() => _character;
    }
}
