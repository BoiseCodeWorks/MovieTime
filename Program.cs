using System;
using movies.Controllers;

namespace movies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            StoreController sc = new StoreController();
            bool running = true;
            while (running)
            {
                Console.WriteLine(@"
 __          __  _                            _          ____  _            _    _               _            
 \ \        / / | |                          | |        |  _ \| |          | |  | |             | |           
  \ \  /\  / /__| | ___ ___  _ __ ___   ___  | |_ ___   | |_) | | ___   ___| | _| |__  _   _ ___| |_ ___ _ __ 
   \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \  |  _ <| |/ _ \ / __| |/ / '_ \| | | / __| __/ _ \ '__|
    \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) | | |_) | | (_) | (__|   <| |_) | |_| \__ \ ||  __/ |   
     \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/  |____/|_|\___/ \___|_|\_\_.__/ \__,_|___/\__\___|_|   
            ");
                running = sc.Start();
            }

        }
    }
}
