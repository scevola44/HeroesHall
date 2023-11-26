using System.Text.Json;

namespace HeroesLodge.Core.JsonReaders
{
    public abstract class BaseJsonReader<T>
    {
        private readonly string BaseDirectory;

        public BaseJsonReader(string baseDirectory)
        {
            BaseDirectory = baseDirectory;
        }

        public string GetFilePath(string subDirectoryName, string fileName) => Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "data", subDirectoryName, $"{fileName}.json"));

        public T LoadHero(string heroName)
        {
            string absolutePath = GetFilePath(BaseDirectory, heroName);
            try
            {
                var heroData = new FileStream(absolutePath, FileMode.Open, FileAccess.Read);
                var heroEntity = JsonSerializer.Deserialize<T>(heroData);

                return heroEntity!;
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not find class file [{heroName}.json]: {ex.Message}");
            }
        }
    }
}