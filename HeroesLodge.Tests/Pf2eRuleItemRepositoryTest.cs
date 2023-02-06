using HeroesLodge.Core;

namespace HeroesLodge.Tests
{
    [TestClass]
    public class Pf2eRuleItemRepositoryTest
    {
        [TestMethod]
        public void LoadClassTest()
        {
            var actual = new Pf2eRuleItemRepository().LoadClass("gunslinger");
            Assert.IsNotNull(actual);
            Assert.AreEqual(typeof(CharacterClass), actual.GetType());
            Assert.AreEqual("Gunslinger", actual.Name);
            Assert.AreEqual("systems/pf2e/icons/classes/gunslinger.webp", actual.Img);
            Assert.AreEqual("Z9li154CPNmun29Q", actual.Id);
            Assert.AreEqual("class", actual.Type);

            var systemClass = actual.SystemClass;
            Assert.IsNotNull(systemClass);
            Assert.AreEqual(1, systemClass.Defenses.Unarmored);
            Assert.AreEqual(1, systemClass.Defenses.Light);
            Assert.AreEqual(1, systemClass.Defenses.Medium);
            Assert.AreEqual(0, systemClass.Defenses.Heavy);
        }
    }
}
