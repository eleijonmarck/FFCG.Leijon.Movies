using System.Collections;
using System.Collections.Generic;

namespace FFCG.Leijon.Movies.Core
{
    public interface IStorage
    {
        T Load<T>(object id);
        void Store(object obj);
        IEnumerable<T> All<T>();
        void Delete(object obj);
    }
}