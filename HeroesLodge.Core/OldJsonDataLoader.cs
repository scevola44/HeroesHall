using Microsoft.Maui.Storage;
using System;
using System.Text.Json;

namespace HeroesLodge.Core
{
	public class OldJsonDataLoader
	{
        private static readonly string JsonDbDirectory = "";
        private const string ClassesDirectory = "classes.db";

        public OldJsonDataLoader()
		{
		}

        public async Task<CharacterClass> LoadClassAsync(string className)
        {
            try
            {
                var classData = await FileSystem.Current.OpenAppPackageFileAsync("fighter.json");
                //var classData = File.ReadAllText("" + className + ".json");
                var characterClass = JsonSerializer.Deserialize<CharacterClass>(classData);

                return characterClass;
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not find class in directory [{""}{className}.json]: {ex.Message}");
            }
        }

        private static string GetFileForCharacterClass(string className) => $"{JsonDbDirectory}/{className}.json";
    }
}

