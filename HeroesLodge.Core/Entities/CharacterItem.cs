namespace HeroesLodge;

public class CharacterItem
{
    public string Name { get; }
    public CharacterClass CharacterClass { get; }

    public CharacterItem(string name, string characterClass)
    {
        this.Name = name;
        this.CharacterClass = new CharacterClass(characterClass);
    }
}