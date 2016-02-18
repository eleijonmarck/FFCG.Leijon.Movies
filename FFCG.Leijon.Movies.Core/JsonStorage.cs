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
        private static bool StorageExists => File.Exists(FilePath);
        private static string FilePath => @"C:\Users\eric.leijonmarck\dev\work\FFCG.Leijon.Movies\storage.txt";

        public JsonStorage()
        {
            if(!StorageExists)
                Save(new List<Movie>());
        }

        public IEnumerable<Movie> GetAll()
        {
            return JsonConvert.DeserializeObject<IEnumerable<Movie>>(File.ReadAllText(FilePath));
        }

        private static void Save(IEnumerable<Movie> movies)
        {
           File.WriteAllText(FilePath,JsonConvert.SerializeObject(movies)); 
        }

        public void Add(Movie movie)
        {
            var movies = GetAll().ToList();
            if (!movies.Contains(movie))
            {
                movies.Add(movie);
                Save(movies);
            }
        }

        public void Remove(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void Update(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
