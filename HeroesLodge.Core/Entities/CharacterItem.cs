using HeroesLodge.Core.Entities;
using HeroesLodge.Core.Rules;

namespace HeroesLodge;

public class CharacterItem
{
    public string Name { get; }
    public CharacterClass CharacterClass { get; set; }
    public SystemHero Build { get; set; } = new SystemHero();
    public CharacterDetails Details { get; set; } = new CharacterDetails();

    public CharacterItem(string name)
    {
        Name = name;
    }
}