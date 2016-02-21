using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using FFCG.Leijon.Movies.Core;

namespace FFCG.Leijon.Movies.WebApi.Controllers
{
    public class MoviesController : ApiController
    {
        // GET api/values
        public IEnumerable<Movie> Get()
        {
            return MovieStorage.Collection.Movies;
        }

        // GET api/values/5
        public Movie Get(int id)
        {
            var movie = MovieStorage.Collection.Movies.FirstOrDefault(x => x.Id == id);
            return movie;
        }

        // POST api/values
        public void Post(CreateMovie input)
        {
            MovieStorage.Collection.AddMovie(new Movie(input.Id,input.Name));
        }
    }

    public class CreateMovie
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
