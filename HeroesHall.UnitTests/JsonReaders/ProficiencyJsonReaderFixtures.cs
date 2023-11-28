using HeroesHall.Core.Entities;
using HeroesHall.Core.JsonReaders;

namespace HeroesHall.UnitTests.JsonReaders;

public class ProficiencyJsonReaderFixtures
{
    [Fact]
    public void Parse()
    {
        var actual = new ProficiencyJsonReader().Load("TestProficiency");

        Assert.NotNull(actual);
        Assert.Equal(CheckType.SavingThrow, actual.Type);
        Assert.Equal(CharacterAttribute.DEX, actual.Attribute);
        Assert.Equal(ProficiencyDegree.Trained, actual.DegreeOfProficiency);
        Assert.Equal("Reflex", actual.Name);
        Assert.Equal("Some Specifics", actual.Specifics);
        Assert.Equal("These are notes. (Also this)", actual.Notes);
    }
}

