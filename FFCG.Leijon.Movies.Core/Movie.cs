using System;

namespace FFCG.Leijon.Movies.Core
{
    public class Movie
    {
        public Guid Id { get; }
        public string Name { get; }

        public Movie() { }

        public Movie(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}