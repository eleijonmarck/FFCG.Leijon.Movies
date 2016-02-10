using System.Collections.Generic;

namespace FFCG.Leijon.Movies.Core
{
    public class MovieCollection
    {
        public readonly IStorage Storage;

        public MovieCollection(IStorage storage)
        {
            Storage = storage;
        }

        public void AddMovie(Movie movie)
        {
            Storage.Add(movie);
        }
    }
}