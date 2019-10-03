using System;
using System.Collections.Generic;
using movies.Models;

namespace movies.Services
{
    class StoreService
    {
        private Blockbuster Store { get; set; }

        public string GetMovies(bool rented)
        {
            List<Movie> movieList;
            if (rented)
            {
                movieList = Store.Rented;
                Console.WriteLine("---- Rented Movies ----");
            }
            else
            {
                movieList = Store.AvailableToRent;
                Console.WriteLine("---- Available Movies ----");
            }
            string movies = "";
            for (int i = 0; i < movieList.Count; i++)
            {
                Movie m = movieList[i];
                movies += $"{i + 1}. {m.Title} \n";
            }
            return movies;
        }

        public string Exchange(int index, bool isRenting)
        {
            List<Movie> from;
            List<Movie> to;
            if (isRenting)
            {
                if (Store.Rented.Count > 1)
                {
                    return "You already have 2 movies";
                }
                from = Store.AvailableToRent;
                to = Store.Rented;
            }
            else
            {
                from = Store.Rented;
                to = Store.AvailableToRent;
            }

            if (index < from.Count)
            {
                Movie movie = from[index];
                from.Remove(movie);
                to.Add(movie);
                return "Thank you for choosing Blockbuster";
            }
            return "invalid movie number";
        }

        public StoreService(string address, string hours)
        {
            Store = new Blockbuster(address, hours);
        }


    }
}