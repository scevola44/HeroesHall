using HeroesLodge.Core.JsonReaders;

namespace HeroesHall.UnitTests.JsonReaders;

public class HeroJsonReaderFixtures
{
    private IHeroJsonReader _sut = new HeroJsonReader();

    [Fact]
    public void LoadHero()
    {
        var actual = _sut.Load("TestHero");
        Assert.Equal("Test Character", actual.Name);
        Assert.Equal(1, actual.Level);
        Assert.Equal(2, actual.Ancestry);
        Assert.Equal(3, actual.Background);
        Assert.Equal("class-4", actual.CharacterClass.ToString());

        Assert.Equal(2, actual.ClassFeats.Keys.Count);

        Assert.Equivalent(new List<string> { "Class Feat lv 1 - A", "Class Feat lv 1 - B" }, actual.ClassFeats[1]);
        Assert.Equivalent(new List<string> { "Class Feat lv 2 - A" }, actual.ClassFeats[2]);
    }
}
