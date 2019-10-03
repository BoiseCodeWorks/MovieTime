using System.Collections.Generic;

namespace movies.Models
{
    class Blockbuster
    {
        public string Address { get; private set; }
        public List<Movie> AvailableToRent { get; set; }
        public List<Movie> Rented { get; set; }
        public string Hours { get; set; }

        public void Setup()
        {
            //Initialize the Movies
            Movie jp = new Movie("Jurassic Park", 97, "Dinosaurs are Awesome!!!", Rating.PG13);
            Movie pm = new Movie("The Pagemaster", 84, "Books are neat!", Rating.PG);
            Movie hp = new Movie("Harry Potter", 98, "Wizards and Explosions", Rating.PG13);
            Movie sc = new Movie("Short Circuit", 75, "Number 5 Alive", Rating.PG13);
            Movie t = new Movie("Titanic", 125, "A boat, not the love boat, but basically with more ice", Rating.PG13);
            //ADD to Available movies
            AvailableToRent.AddRange(new Movie[] { jp, pm, hp, sc, t });
        }

        public Blockbuster(string address, string hours)
        {
            Address = address;
            Hours = hours;
            //NOTE Always Initalize your Lists and Dictionaries in the constructor.
            AvailableToRent = new List<Movie>();
            Rented = new List<Movie>();
            Setup();
        }
    }
}