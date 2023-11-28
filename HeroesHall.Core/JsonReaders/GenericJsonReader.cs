using System.Text.Json;

namespace HeroesLodge.Core.JsonReaders
{
    public abstract class GenericJsonReader<T>
    {
        private readonly string BaseDirectory;

        public GenericJsonReader(string baseDirectory)
        {
            BaseDirectory = baseDirectory;
        }

        public string GetFilePath(string subDirectoryName, string fileName) => Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "data", subDirectoryName, $"{fileName}.json"));

        public T Load(string fileName)
        {
            string absolutePath = GetFilePath(BaseDirectory, fileName);
            try
            {
                var jsonAsStream = new FileStream(absolutePath, FileMode.Open, FileAccess.Read);
                var resultEntity = JsonSerializer.Deserialize<T>(jsonAsStream);

                return resultEntity!;
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not find class file [{fileName}.json]: {ex.Message}");
            }
        }
    }
}