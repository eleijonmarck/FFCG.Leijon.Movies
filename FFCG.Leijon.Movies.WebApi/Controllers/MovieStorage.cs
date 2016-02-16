using System;
using FFCG.Leijon.Movies.Core;

namespace FFCG.Leijon.Movies.WebApi.Controllers
{
    public static class MovieStorage
    {
        public static MovieCollection MovieCollection;

        static MovieStorage()
        {
            MovieCollection = new MovieCollection(new JsonStorage());
            MovieCollection.AddMovie(new Movie(Guid.NewGuid(), "test1"));
            MovieCollection.AddMovie(new Movie(Guid.NewGuid(), "test2"));
            MovieCollection.AddMovie(new Movie(Guid.NewGuid(), "test3"));
            MovieCollection.AddMovie(new Movie(Guid.NewGuid(), "test4"));
        }
    }
}