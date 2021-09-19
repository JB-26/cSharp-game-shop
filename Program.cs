using System;
using System.Collections.Generic;
using System.IO;
using System.Net;


namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<VideoGame> gameList = new List<VideoGame>();
            Console.WriteLine("Hello World!");
            String name = "Josh";

            System.Console.WriteLine($"My name is {name}");

            var mario64 = new VideoGame{name = "Super Mario 64", publisher = "Nintendo", platform = "Nintendo 64", pricePounds = 49.99};
            var klonoa = new VideoGame{name = "Klonoa", publisher = "Namco", platform = "Playstation", pricePounds = 39.99};

            gameList.Add(mario64);
            gameList.Add(klonoa);


            foreach (var item in gameList)
            {
                item.PrintGame(item.name, item.publisher, item.platform, item.pricePounds);
                System.Console.WriteLine("\n");
            }
            
            System.Console.WriteLine($"You have {gameList.Count} games!");
        }
    }
}
