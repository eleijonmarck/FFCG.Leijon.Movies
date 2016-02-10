using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FFCG.Leijon.Movies.Core.Tests
{
    [TestFixture]
    public class JsonStorageTests
    {

        [SetUp]
        public void SetUp()
        {
            var storage = new FakeStorage();
        }

        [Test]
        public void Should_be_able_to_add_movie()
        {
        }
    }
}
