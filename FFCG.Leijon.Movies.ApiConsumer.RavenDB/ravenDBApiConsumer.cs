using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FFCG.Leijon.Movies.Core;
using Raven.Client.Document;
using Raven.Imports.Newtonsoft.Json;

namespace FFCG.Leijon.Movies.ApiConsumer.RavenDB
{
    class RavenDbApiConsumer
    {
        static void Main(string[] args)
        {
            const string baseUrl = "https://api.themoviedb.org/3/movie/popular/?api_key=50bfb202877fce6b0d15c9d434cbd1e2";
            const string baseImageUrl = "https://image.tmdb.org/tY/p/w370";
            const string completeUrl = baseUrl + "&page=1";

            // TODO: ask jens about the storeHolder()
            //var documentStore = new DocumentStoreHolder();
            var documentStore = new DocumentStore()
            {
                Url = "http://ericle:8080/",
                DefaultDatabase = "Movies"
            };

            documentStore.Initialize();

            using (var session = documentStore.OpenSession())
            {
                using (var webClient = new WebClient())
                {
                    webClient.Encoding = Encoding.UTF8;

                    var resultString = webClient.DownloadString(completeUrl);
                    var movieResults = JsonConvert.DeserializeObject<MovieResults>(resultString);

                    foreach (
                        var movie in
                            movieResults.results.Select(movieResult => new Movie(movieResult.id, movieResult.title)
                            {
                                Overview = movieResult.overview,
                                Popularity = movieResult.popularity,
                                PosterPath = baseImageUrl + movieResult.poster_path
                            }))
                    {
                        session.Store(movie);
                    }
                }
            }
        }
    }
}
