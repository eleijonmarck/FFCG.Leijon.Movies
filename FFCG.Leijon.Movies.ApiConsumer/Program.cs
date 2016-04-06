using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using FFCG.Leijon.Movies.Core;
using Newtonsoft.Json;

namespace FFCG.Leijon.Movies.ApiConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            const string baseUrl = "https://api.themoviedb.org/3/movie/popular/?api_key=50bfb202877fce6b0d15c9d434cbd1e2";
            const string baseImageUrl = "https://image.tmdb.org/tY/p/w370";
            var storage = new FileStorage(@"c:\temp\Movies.API");

            const string completeUrl = baseUrl + "&page=1";
            using (var webClient = new WebClient())
            {
                webClient.Encoding = Encoding.UTF8;

                var resultString = webClient.DownloadString(completeUrl);

                var movieResults = JsonConvert.DeserializeObject<MovieResults>(resultString);

                foreach (var movie in movieResults.results.Select(movieResult => new Movie(movieResult.id, movieResult.title)
                {
                    Overview = movieResult.overview,
                    Popularity = movieResult.popularity,
                    PosterPath = baseImageUrl + movieResult.poster_path
                }))
                {
                    storage.Store(movie);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Stored movies! We got em!");
                Console.ResetColor();
            }
    }
    }
}
