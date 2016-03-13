using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FFCG.Leijon.Movies.Core.Tests
{
    [Ignore("Integration tests")]
    [TestFixture]
    public class JsonStorageTests
    {
        private JsonStorage _storage;

        [SetUp]
        public void SetUp()
        {
            _storage = new JsonStorage();
        }

        [Test]
        public void Should_be_able_to_add_movie()
        {
        }
    }
}
