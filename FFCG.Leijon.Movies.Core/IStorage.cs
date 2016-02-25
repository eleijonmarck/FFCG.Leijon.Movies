using System.Collections;
using System.Collections.Generic;

namespace FFCG.Leijon.Movies.Core
{
    public interface IStorage
    {
        IEnumerable<Movie> GetAll();
        void Add(Movie movie);
    }
}