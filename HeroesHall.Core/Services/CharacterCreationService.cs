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

            _hero.Checks.SavingThrows = characterClass.InitialProficiencies
                .FindAll(x => x.Type == CheckType.SavingThrow)
                .ToDictionary(st => Enum.Parse<SavingThrowName>(st.Name), st => st);

            _hero.Checks.Perception = characterClass.InitialProficiencies.Single(x => x.Type == CheckType.Perception);

            _hero.Checks.Skills = characterClass.InitialProficiencies
                .FindAll(x => x.Type == CheckType.Skill)
                .ToDictionary(st => Enum.Parse<SkillName>(st.Name), st => st);

            _hero.Checks.LoreChecks = characterClass.InitialProficiencies
                .FindAll(x => x.Type == CheckType.Lore)
                .ToDictionary(st => st.Specifics, st => st);
        }

        public Hero GetHero() => _hero;
    }
}

