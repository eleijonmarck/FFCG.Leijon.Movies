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
        private static string FilePath => "storage.txt";
        private static bool StorageExists => File.Exists(FilePath);
        public JsonStorage()
        {
            if(!StorageExists)
                Save(new List<Movie>());
        }

        public IEnumerable<Movie> GetAll()
        {
            var text = File.ReadAllText(@"C:\Users\eric.leijonmarck\dev\work\FFCG.Leijon.Movies.Core\lol.txt");
            return (IEnumerable<Movie>)JsonConvert.DeserializeObject(text);
        }
        //File.ReadAllText(Path.GetDirectoryName("."))

        private static void Save(IEnumerable<Movie> movies)
        {
           File.WriteAllText(FilePath,JsonConvert.SerializeObject(movies)); 
        }

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
