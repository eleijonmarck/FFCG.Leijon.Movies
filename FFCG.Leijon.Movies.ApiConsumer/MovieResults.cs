using System.Collections.Generic;

namespace FFCG.Leijon.Movies.ApiConsumer
{
    public class MovieResults
    {
        public int page { get; set; }
        public int total_pages { get; set; }
        public List<MovieResult> results { get; set; } 
    }

    public class MovieResult
    {
        public int id { get; set; }
        public string title { get; set; }
        public string overview { get; set; }
        public decimal popularity { get; set; }
        public string poster_path { get; set; }
    }
}