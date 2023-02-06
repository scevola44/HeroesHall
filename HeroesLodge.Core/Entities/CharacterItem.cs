namespace HeroesLodge;

public class CharacterItem
{
    public string Name { get; }
    public CharacterClass CharacterClass { get; set; }

    public CharacterItem(string name)
    {
        Name = name;
    }
}