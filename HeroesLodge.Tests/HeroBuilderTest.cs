using HeroesLodge.Core;

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
    }
}
