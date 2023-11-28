using HeroesHall.Core.Entities;
using HeroesHall.Core.JsonReaders;

namespace HeroesHall.UnitTests.JsonReaders;

public class CharacterClassJsonReaderFixtures
{
    [Fact]
    public void Load()
    {
        var sut = new CharacterClassJsonReader();
        var actual = sut.Load("TestBarbarian");

        Assert.NotNull(actual);
        Assert.Equal("Barbarian", actual.Name);
        Assert.Equal("class-2", actual.Id);

        var perceptionProficiency = actual.InitialProficiencyPerception;
        Assert.Equal("Perception", perceptionProficiency.Name);
        Assert.Equal(ProficiencyDegree.Expert, perceptionProficiency.DegreeOfProficiency);
        Assert.Equal(CharacterAttribute.WIS, perceptionProficiency.Attribute);

        var skillProficiencies = actual.InitialProficienciesSkills;
        Assert.Single(skillProficiencies);

        var loreProficiency = actual.InitialProficienciesLore.Single();
        Assert.Equal("Warfare", loreProficiency.Specifics);

        var savingThrowsProficiencies = actual.InitialProficienciesSavingThrows;
        Assert.Equal(3, savingThrowsProficiencies.Count);
        Assert.Equal(ProficiencyDegree.Expert, savingThrowsProficiencies.Single(x => x.Name == "Fortitude").DegreeOfProficiency);
        Assert.Equal(ProficiencyDegree.Trained, savingThrowsProficiencies.Single(x => x.Name == "Reflex").DegreeOfProficiency);
        Assert.Equal(ProficiencyDegree.Expert, savingThrowsProficiencies.Single(x => x.Name == "Will").DegreeOfProficiency);
    }
}

