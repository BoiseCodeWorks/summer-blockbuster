using System.Collections.Generic;

namespace blockbuster.Models
{
    abstract class Movie
    {
        public string Title { get; set; }
        public string Plot { get; set; }
        public int ReleaseYear { get; set; }
        public List<Actor> Actors { get; private set; }

        public void AddActor(Actor actor)
        {
            Actors.Add(actor);
            actor.Filmography.Add(this);
        }

        public Movie(string title, string plot, int year)
        {
            Title = title;
            Plot = plot;
            ReleaseYear = year;
            Actors = new List<Actor>();
        }
    }
}