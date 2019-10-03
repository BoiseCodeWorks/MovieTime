using System;
using movies.Services;

namespace movies.Controllers
{
    class StoreController
    {
        private StoreService StoreService { get; set; }
        private string Menu { get; set; }

        public bool GetUserInput()
        {
            string options = $"Choose from the following options: \nEnter the movie number to {Menu} \n";
            if (Menu == "return")
            {
                options += "'A' to see available movies \n";
            }
            else
            {
                options += "'R' to see movies to return \n";
            }
            options += "'Q' to quit";

            Console.WriteLine(options);
            string choice = Console.ReadLine().ToLower();
            Console.Clear();
            if (int.TryParse(choice, out int choiceIndex))
            {
                System.Console.WriteLine(StoreService.Exchange(choiceIndex - 1, Menu == "rent"));
                return true;
            }

            switch (choice)
            {
                case "r":
                    Menu = "return";
                    return true;
                case "a":
                    Menu = "rent";
                    return true;
                case "q":
                    return false;
                default:
                    System.Console.WriteLine("Invalid Command");
                    return true;
            }
        }


        public bool Start()
        {
            System.Console.WriteLine(StoreService.GetMovies(Menu == "return"));
            return GetUserInput();
        }








        public StoreController()
        {
            StoreService = new StoreService("123 fake st", "11am-11pm");
            Menu = "rent";
        }
    }
}