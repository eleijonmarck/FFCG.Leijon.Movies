using FFCG.Leijon.Movies.Core;

namespace FFCG.Leijon.Movies.WebApi.Controllers
{
    public static class MovieStorage
    {
        public static MovieCollection Collection = new MovieCollection(new JsonStorage());

        static MovieStorage()
        {
            Collection.AddMovie(new Movie(1, "test1"));
            Collection.AddMovie(new Movie(2, "test2"));
        }
    }
}