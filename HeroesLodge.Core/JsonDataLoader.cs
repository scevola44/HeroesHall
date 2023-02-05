using System;
using System.Text.Json;

namespace HeroesLodge.Core
{
	public class JsonDataLoader
	{
        private const string JsonDbDirectory = "/Users/scevola/Documents/pf2e-master/packs/data";
        private const string ClassesDirectory = "classes.db";

        public JsonDataLoader()
		{
		}

        public CharacterClass LoadClass(string className)
        {
            var classData = File.ReadAllText(GetFileForCharacterClass(className));
            var characterClass = JsonSerializer.Deserialize<CharacterClass>(classData);

            return characterClass;
        }

        private static string GetFileForCharacterClass(string className) => $"{JsonDbDirectory}/{ClassesDirectory}/{className}.json";
    }
}

