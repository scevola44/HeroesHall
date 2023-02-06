using HeroesLodge.Core;
using HeroesLodge.Core.Rules;

namespace HeroesLodge;

public class CharacterItem
{
    public string Name { get; }
    public CharacterClass CharacterClass { get; set; }
    public SystemHero Build { get; set; } = new SystemHero();

    public CharacterItem(string name)
    {
        Name = name;
    }

    public int ArmorClass(ArmorType armorType)
    {
        return 10 + (int)CharacterClass.SystemClass.Defenses.GetType().GetProperty(armorType.ToString()).GetValue(CharacterClass.SystemClass.Defenses);
    }
}