using HeroesLodge.Core;

namespace HeroesLodge.Tests
{
    [TestClass]
    public class FileLoaderTest
    {
        [TestMethod]
        public void LoadTest()
        {
            var result = FileLoader.ReadClassFile("Classes\\gunslinger.json");
            Assert.IsNotNull(result);
        }
    }
}
