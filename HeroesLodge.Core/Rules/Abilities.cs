namespace HeroesLodge.Core.Rules
{
    public class Abilities
    {
        public int Strength { get; set; } = 10;
        public int Dexterity { get; set; } = 10;
        public int Constitution { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public int Wisdom { get; set; } = 10;
        public int Charisma { get; set; } = 10;

        public Dictionary<int, List<Ability>> BoostsPerLevel { get; set; } = new Dictionary<int, List<Ability>>();

        public void ReloadAttributes()
        {
            foreach (var boost in BoostsPerLevel) {
                foreach (var ability in boost.Value)
                {
                    var abilityToBoost = this.GetType().GetProperty(ability.ToString());
                    var abilityValue = (int)abilityToBoost.GetValue(this);

                    if (abilityValue < 18) abilityToBoost.SetValue(this, abilityValue + 2);
                    else abilityToBoost.SetValue(this, abilityValue + 1);
                }
            }
        }
    }
}
