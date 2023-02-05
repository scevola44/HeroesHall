using System.Reflection;

namespace HeroesLodge.Core
{
    public static class FileLoader
    {
        private static readonly string CharacterClassesDirectory = Path.Combine(AssemblyDirectory, "TestResources");

        public static Stream ReadClassFile(string className)
        {
            var filePath = Path.Combine(CharacterClassesDirectory, $"{className}.json");
            return new FileStream(filePath, FileMode.Open, FileAccess.Read);
        }

        public static string AssemblyDirectory
        {
            get
            {
                var path = Assembly.GetExecutingAssembly().Location;
                if (path == null)
                    throw new Exception($"Assembly.GetExecutingAssembly().Location was null");

                return Path.Combine(Path.GetDirectoryName(path), "..\\..\\..\\")!;
            }
        }
    }
}
