using System;
using System.Collections.Generic;


namespace myApp
{
    class Program
    {
        //holds a list of objects
        static List<VideoGame> gameList = new List<VideoGame>();
        static void Main(string[] args)
        {
            //ensures a loop for the menu
            Boolean runProgram = true;
            while (runProgram == true)
            {
                System.Console.WriteLine("Welcome to the video game shop!\nPlease enter a command of what you want to do!");

                System.Console.WriteLine("A)dd game\nV)iew games\nD)elete game\nQ)uit");

                String choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "A":
                        AddGame();
                        break;
                    case "V":
                        ViewGames();
                        break;
                    case "D":
                        RemoveGame();
                        break;
                    case "Q":
                        System.Console.WriteLine("Bye!");
                        runProgram = false;
                        break;
                    default:
                        System.Console.WriteLine("I don't understand that! Try again!");
                        break;
                }
            };
        }

        private static void ViewGames()
        {
            //check if the list is empty
            if (gameList.Count != 0)
            {
                System.Console.WriteLine($"You have {gameList.Count} games in the shop!");
                foreach (var item in gameList)
                {
                    item.PrintGame();
                    System.Console.WriteLine();
                }
            }
            else
            {
                System.Console.WriteLine("You don't have any games!");
            }
        }

        public static void AddGame()
        {
            try
            {
                //get information from user to create new object
                System.Console.WriteLine("Add new game.");
                System.Console.WriteLine("Enter the name of the game.");
                String gameName = Console.ReadLine();

                System.Console.WriteLine("Enter the publisher of the game.");
                String gamePublisher = Console.ReadLine();

                System.Console.WriteLine("Enter the platform of the game.");
                String gamePlatform = Console.ReadLine();

                System.Console.WriteLine("Enter the price of the game.");
                String gamePriceString = Console.ReadLine();
                Double gamePrice = Convert.ToDouble(gamePriceString);

                //creates a unique ID for the game
                Double gameId = gameList.Count + 1;

                System.Console.WriteLine("Adding new game...");
                //create new game object
                var newGame = new VideoGame
                {
                    name = gameName,
                    publisher = gamePublisher,
                    platform = gamePublisher,
                    pricePounds = gamePrice,
                    id = gameId
                };
                //print details
                newGame.PrintGame();
                //add to list
                gameList.Add(newGame);
                System.Console.WriteLine("Game added!");
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error! Please try again!");
                System.Console.WriteLine($"{e}");
            }
        }

        public static void RemoveGame()
        {
            //check if list is empty
            if (gameList.Count != 0)
            {
                try
                {
                    System.Console.WriteLine("WARNING! Removing a game from the list can't be undone!");
                    System.Console.WriteLine("List of games...");
                    //print IDs and names of games in list
                    foreach (var item in gameList)
                    {
                        System.Console.WriteLine($"ID: {item.id}\nName: {item.name}");
                        System.Console.WriteLine();
                    }
                    System.Console.WriteLine($"You have {gameList.Count} games at the moment.");
                    System.Console.WriteLine("Enter the ID of the game you wish to delete.");

                    //elements start at 0 - so subtract 1
                    int gameId = Convert.ToInt16(Console.ReadLine()) - 1;
                    System.Console.WriteLine("Now removing game...");
                    //remove game from list
                    gameList.RemoveAt(gameId);
                    System.Console.WriteLine("Game removed!");
                }
                catch (Exception e)
                {
                    System.Console.WriteLine("Error! Please try again!");
                    System.Console.WriteLine($"{e}");
                }
            }
            else
            {
                System.Console.WriteLine("There are no games to remove!");
            }

        }
    }
}
