using System.Collections.Generic;
using System.IO;

namespace FFCG.Leijon.Movies.Core.Tests
{
    public class FakeStorage : IStorage
    {
        public FakeStorage()
        {
            _movies = new List<Movie>();
        }

        private readonly List<Movie> _movies;

        public IEnumerable<Movie> GetAll() => _movies;

        public void Add(Movie movie)
        {
            if (!_movies.Contains(movie))
            {
                _movies.Add(movie);
            }
        }

        public T Load<T>(object id)
        {
            throw new System.NotImplementedException();
        }

        public void Store(object obj)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> All<T>()
        {
            throw new System.NotImplementedException();
        }

        public void Delete(object obj)
        {
            throw new System.NotImplementedException();
        }
    }
}