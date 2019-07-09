using System.Collections.Generic;

namespace blockbuster.Models
{
    class Actor
    {
        public string Name { get; set; }
        public List<Movie> Filmography { get; set; }

        public Actor(string name)
        {
            Name = name;
            Filmography = new List<Movie>();
        }
    }
}