using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FFCG.Leijon.Movies.Core
{
    public class JsonStorage : IStorage
    {
        public JsonStorage()
        {
            var movie = new Movie("test",Guid.NewGuid());
            this.Add(movie);
        }

        public IEnumerable<Movie> GetAll()
        {
            var text = File.ReadAllText(@"C:\Users\eric.leijonmarck\dev\work\FFCG.Leijon.Movies.Core\lol.txt");
            return (IEnumerable<Movie>)JsonConvert.DeserializeObject(text);
        }
        //File.ReadAllText(Path.GetDirectoryName("."))

        public void Add(Movie movie)
        {
            var text = File.ReadAllText(@"C:\Users\eric.leijonmarck\dev\work\FFCG.Leijon.Movies.Core\lol.txt");
            var movies = (List<Movie>)JsonConvert.DeserializeObject(text);
            movies.Add(movie);
            File.WriteAllText(@"C:\Users\eric.leijonmarck\dev\work\FFCG.Leijon.Movies.Core\lol.txt",JsonConvert.SerializeObject(movies));
        }

        public void Remove(Movie movie)
        {
            throw new NotImplementedException();
        }

        Movie IStorage.Get(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
