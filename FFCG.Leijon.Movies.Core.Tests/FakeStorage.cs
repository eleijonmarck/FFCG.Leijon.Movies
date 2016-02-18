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

        public void Add(Movie movie)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Movie movie)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Movie movie)
        {
            throw new System.NotImplementedException();
        }
    }
}