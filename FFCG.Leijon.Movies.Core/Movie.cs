using System;

namespace FFCG.Leijon.Movies.Core
{
    public class Movie
    {
        public Guid Id { get; private set;}
        public string Name { get; private set; }

        public Movie(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}