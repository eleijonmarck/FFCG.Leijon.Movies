using System;

namespace FFCG.Leijon.Movies.Core
{
    public class Movie
    {
        public string Name { get; private set; }
        public Guid Id { get; private set;}

        public Movie(string name, Guid id)
        {
            Name = name;
            Id = id;
        }
    }
}