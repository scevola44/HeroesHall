using HeroesLodge.Core;

namespace HeroesLodge.Tests
{
    [TestClass]
    public class FileLoaderTest
    {
        [TestMethod]
        public void LoadTest()
        {
            var result = FileLoader.ReadClassFile("gunslinger");
            Assert.IsNotNull(result);
        }
    }

    //internal class FileLoaderForTest : FileLoader
}
