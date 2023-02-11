using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesLodge.Core
{
    public class CharacterSheet
    {
        private CharacterItem _character;

        public CharacterSheet(CharacterItem character)
        {
            _character = character; 
        }

        public int ArmorClass(ArmorType armorType)
        {
            return 10 + (int)_character.CharacterClass.SystemClass.Defenses.GetType().GetProperty(armorType.ToString()).GetValue(_character.CharacterClass.SystemClass.Defenses);
        }

        public int StrengthScore()
        {
            return 10 + _character.Details.KeyAbility == "str" ? 2 : 0;
        }
    }
}
