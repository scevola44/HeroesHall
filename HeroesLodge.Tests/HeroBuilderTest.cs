using HeroesLodge.Core;
using HeroesLodge.Core.Rules;

namespace HeroesLodge.Tests
{
    [TestClass]
    public class HeroBuilderTest
    {
        [TestMethod]
        public void CreateUserWithClass()
        {
            var builder = new HeroBuilder("test-character");
            Assert.IsNull(builder.Build().CharacterClass);

            builder.SetClass("gunslinger");
            var hero = builder.Build();
            Assert.IsNotNull(hero.CharacterClass);
            Assert.AreEqual("Gunslinger", hero.CharacterClass.Name);
        }

        [TestMethod]
        public void HeroHasAttributes()
        {
            var hero = new HeroBuilder("character-with-ability-scores").SetBoosts(1, new List<Ability> { Ability.Dexterity }).Build();

            Assert.AreEqual(10, hero.Build.Abilities.Strength);
            Assert.AreEqual(12, hero.Build.Abilities.Dexterity);
            Assert.AreEqual(10, hero.Build.Abilities.Constitution);
            Assert.AreEqual(10, hero.Build.Abilities.Wisdom);
            Assert.AreEqual(10, hero.Build.Abilities.Intelligence);
            Assert.AreEqual(10, hero.Build.Abilities.Charisma);
        }
    }
}
