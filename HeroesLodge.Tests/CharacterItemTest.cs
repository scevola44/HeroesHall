namespace HeroesLodge.Tests;

[TestClass]
public class CharacterItemTest
{
    [TestMethod]
    public void CharacterCreationBase()
    {
        var character = new CharacterItem("Morgan", "fighter");
        Assert.AreEqual(character.Name, "Morgan");
        Assert.AreEqual(character.CharacterClass.name, "fighter");
    }
}
