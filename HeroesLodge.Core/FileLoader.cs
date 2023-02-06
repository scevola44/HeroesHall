namespace HeroesLodge.Core
{
    public static class FileLoader
    {
        private static readonly string PF2DatabaseDirectory = Path.Combine(AssemblyDirectory, "PF2Database");

        public static Stream ReadClassFile(string filePath)
        {
            return new FileStream(Path.Combine(PF2DatabaseDirectory, $"{filePath}"), FileMode.Open, FileAccess.Read);
        }

        public static string AssemblyDirectory
        {
            get
            {
                return Path.Combine(Path.GetDirectoryName(AppContext.BaseDirectory), "..\\..\\..\\")!;
            }
        }
    }
}
