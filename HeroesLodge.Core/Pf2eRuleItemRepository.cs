using System.Text.Json;

namespace HeroesLodge.Core
{
    public class Pf2eRuleItemRepository
	{
        private static readonly string JsonDbDirectory = "";
        private static readonly string CharacterClassesDirectory = "Classes";

        public Pf2eRuleItemRepository()
		{
		}

        public CharacterClass LoadClass(string className)
        {
            try
            {
                var classData = FileLoader.ReadClassFile(GetFileForCharacterClass(className));
                var characterClass = JsonSerializer.Deserialize<CharacterClass>(classData);

                return characterClass;
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not find class file [{className}.json]: {ex.Message}");
            }
        }

        private static string GetFileForCharacterClass(string className) => Path.Combine(CharacterClassesDirectory, $"{className}.json");
    }
}

