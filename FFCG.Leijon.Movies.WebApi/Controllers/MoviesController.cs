using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FFCG.Leijon.Movies.Core;
using Newtonsoft.Json;

namespace FFCG.Leijon.Movies.WebApi.Controllers
{
    public class MoviesController : ApiController
    {
        private readonly MovieCollection _collection = new MovieCollection(new JsonStorage());

        // GET api/values
        public string Get()
        {
            return JsonConvert.DeserializeObject<string>(JsonConvert.SerializeObject(_collection.Storage.GetAll()));
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
