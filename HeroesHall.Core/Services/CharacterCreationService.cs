using System;
using HeroesHall.Core.Entities;
using HeroesHall.Core.JsonReaders;

namespace HeroesHall.Core.Services
{
	public class CharacterCreationService
	{
        private readonly Hero _hero;

		public CharacterCreationService()
		{
            _hero = new Hero();
		}

        public void SelectClass(string className)
        {
            var characterClass = new CharacterClassJsonReader().Load(className);
            _hero.CharacterClass = characterClass.Id;

            _hero.Checks.SavingThrows = characterClass.InitialProficienciesSavingThrows
                .ToDictionary(st => Enum.Parse<SavingThrowName>(st.Name), st => st);

            _hero.Checks.Perception = characterClass.InitialProficiencyPerception;

            _hero.Checks.Skills = characterClass.InitialProficienciesSkills
                .ToDictionary(st => Enum.Parse<SkillName>(st.Name), st => st);

            _hero.Checks.LoreChecks = characterClass.InitialProficienciesLore
                .ToDictionary(st => st.Specifics, st => st);
        }

        public Hero GetHero() => _hero;
    }
}

