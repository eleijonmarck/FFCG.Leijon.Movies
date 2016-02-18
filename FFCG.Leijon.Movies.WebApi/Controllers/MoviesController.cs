using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc.Html;
using FFCG.Leijon.Movies.Core;
using Newtonsoft.Json;

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
        public Movie Get(Guid id)
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
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
