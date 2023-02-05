using HeroesLodge.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesLodge
{
    [TestFixture]
    public class DataLoaderTest
    {
        [Test]
        public void LoadDataTest()
        {
            var actual = new JsonDataLoader().LoadClassAsync("fighter").Result;
            Assert.AreEqual("Fighter", actual.name);
        }
    }
}
