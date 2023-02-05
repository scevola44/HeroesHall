using System;
using HeroesLodge.Core;

namespace HeroesLodge.Tests
{
    [TestClass]
    public class JsonDataLoaderTest
	{
		private readonly JsonDataLoader _loader = new JsonDataLoader();

		[TestMethod]
		public void LoadCharacterClass()
		{
			var characterClass = _loader.LoadClass("fighter");
			Assert.AreEqual("Fighter", characterClass.name);
		}
	}
}

