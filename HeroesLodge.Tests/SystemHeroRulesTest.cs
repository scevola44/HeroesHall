using HeroesLodge.Core;

namespace HeroesLodge.Tests
{
    [TestClass]
    public class SystemHeroRulesTest
    {
        [DataTestMethod]
        [DataRow(ArmorType.Unarmored, 1)]
        [DataRow(ArmorType.Light, 1)]
        [DataRow(ArmorType.Medium, 1)]
        [DataRow(ArmorType.Heavy, 0)]
        public void ArmorClassTest(ArmorType armorType, int proficiency)
        {
            var hero = new HeroBuilder("test").SetClass("gunslinger").Build();

            var expectedArmorClass = 10 + proficiency;
            Assert.AreEqual(expectedArmorClass, hero.ArmorClass(armorType));
        }
    }
}
