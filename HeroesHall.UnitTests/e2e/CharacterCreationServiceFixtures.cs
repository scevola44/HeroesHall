using HeroesHall.Core.Entities;
using HeroesHall.Core.Services;

namespace HeroesHall.UnitTests.e2e;

public class CharacterCreationServiceFixtures
{
	private CharacterCreationService _sut = new();

	[Fact]
	public void SelectClass()
	{
		_sut.SelectClass("TestBarbarian");

        var actualHero = _sut.GetHero();

		Assert.NotNull(actualHero);
		Assert.Equal(2, actualHero.CharacterClass);

		var actualSavingThrows = actualHero.Checks.SavingThrows;
		Assert.Equal(ProficiencyDegree.Expert, actualSavingThrows[SavingThrowName.Fortitude].DegreeOfProficiency);
        Assert.Equal(ProficiencyDegree.Trained, actualSavingThrows[SavingThrowName.Reflex].DegreeOfProficiency);
		Assert.Equal(ProficiencyDegree.Expert, actualSavingThrows[SavingThrowName.Will].DegreeOfProficiency);

		Assert.Equal(ProficiencyDegree.Expert, actualHero.Checks.Perception.DegreeOfProficiency);

		var actualSkills = actualHero.Checks.Skills.Single();
		Assert.Equal(SkillName.Athletics, actualSkills.Key);
		Assert.Equal(ProficiencyDegree.Trained, actualSkills.Value.DegreeOfProficiency);

		Assert.Equal(ProficiencyDegree.Trained, actualHero.Checks.LoreChecks["Warfare"].DegreeOfProficiency);
    }
}

