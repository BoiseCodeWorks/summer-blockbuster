using System;
using System.Collections.Generic;
using blockbuster.Interfaces;

namespace blockbuster.Models
{
    class Store
    {
        public string Location { get; set; }
        public List<IRentable> AvailableRentals { get; private set; }
        public List<IRentable> Rented { get; private set; }

        public List<IPurchasable> StuffToBuy { get; private set; }


        //add movies to available
        public void AddMovie(IRentable m)
        {
            AvailableRentals.Add(m);
        }

        public void Print(bool available)
        {
            var rentables = AvailableRentals;
            System.Console.WriteLine("Movies: ");
            if (!available)
            {
                rentables = Rented;
            }
            int counter = 1;
            foreach (var movie in rentables)
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
            List<IRentable> movies = AvailableRentals;
            if (!available)
            {
                movies = Rented;
            }
            IRentable movie = ValidateSelection(choice, movies);
            if (movie != null)
            {
                if (available)
                {
                    if (Rented.Count > 1)
                    {
                        System.Console.WriteLine("You already have 2 movies out! Please Return first");
                        return;
                    }
                    AvailableRentals.Remove(movie);
                    Rented.Add(movie);
                    System.Console.WriteLine($"Enjoy {movie.Title}");
                    return;
                }
                AvailableRentals.Add(movie);
                Rented.Remove(movie);
                System.Console.WriteLine($"Thank you for returning {movie.Title}");
                return;
            }
            System.Console.WriteLine("Invalid Selection");
        }

        private IRentable ValidateSelection(string choice, List<IRentable> movies)
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
            AvailableRentals = new List<IRentable>();
            Rented = new List<IRentable>();
        }


    }
}