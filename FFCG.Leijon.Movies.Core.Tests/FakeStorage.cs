using System.Collections.Generic;
using System.IO;

namespace FFCG.Leijon.Movies.Core.Tests
{
    public class FakeStorage : IStorage
    {
        public IEnumerable<Movie> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Movie> Add()
        {
            throw new System.NotImplementedException();
        }
    }
}