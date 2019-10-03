namespace movies.Models
{
    class Movie
    {
        public string Title { get; private set; }
        public int RuntimeMinutes { get; private set; }
        public string Description { get; private set; }
        public Rating Rating { get; private set; }



        public Movie(string title, int runtime, string desc, Rating rating)
        {
            Title = title;
            RuntimeMinutes = runtime;
            Description = desc;
            Rating = rating;
        }
    }

    enum Rating
    {
        R,
        PG13,
        PG,
        G,
        Unrated
    }







}