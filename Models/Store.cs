using System;
using System.Collections.Generic;

namespace blockbuster.Models
{
    class Store
    {
        public string Location { get; set; }
        public List<Movie> AvailableMovies { get; private set; }
        public List<Movie> RentedMovies { get; private set; }


        //add movies to available
        public void AddMovie(Movie m)
        {
            AvailableMovies.Add(m);
        }

        public void Print(bool available)
        {
            List<Movie> movies = AvailableMovies;
            System.Console.WriteLine("Movies: ");
            if (!available)
            {
                movies = RentedMovies;
            }
            int counter = 1;
            foreach (var movie in movies)
            {
                Console.WriteLine($"{counter}. {movie.Title}");
                counter++;
            }
            if (available)
            {
                System.Console.WriteLine("Enter the number for the movie to rent or type 'return' to return a movie");
            }
            else
            {
                System.Console.WriteLine("Enter the number for the movie to return or type 'rent' to rent a movie");
            }

        }

        //RENT MOVIE
        //RETURN MOVIE
        public void ExchangeMovie(string choice, bool available)
        {
            List<Movie> movies = AvailableMovies;
            if (!available)
            {
                movies = RentedMovies;
            }
            Movie movie = ValidateSelection(choice, movies);
            if (movie != null)
            {
                if (available)
                {
                    if (RentedMovies.Count > 1)
                    {
                        System.Console.WriteLine("You already have 2 movies out! Please Return first");
                        return;
                    }
                    AvailableMovies.Remove(movie);
                    RentedMovies.Add(movie);
                    System.Console.WriteLine($"Enjoy {movie.Title}");
                    return;
                }
                AvailableMovies.Add(movie);
                RentedMovies.Remove(movie);
                System.Console.WriteLine($"Thank you for returning {movie.Title}");
                return;
            }
            System.Console.WriteLine("Invalid Selection");
        }

        private Movie ValidateSelection(string choice, List<Movie> movies)
        {
            if (Int32.TryParse(choice, out int index))
            {
                index--;
                if (index > -1 && index < movies.Count)
                {
                    return movies[index];
                }
            }
            return null;
        }

        public Store(string location)
        {
            Location = location;
            AvailableMovies = new List<Movie>();
            RentedMovies = new List<Movie>();
        }


    }
}