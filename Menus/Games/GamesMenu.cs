using Sebo_nas_Canelas_3.AppObjects;
using Sebo_nas_Canelas_3.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sebo_nas_Canelas_3.Menus.Games
{
    public static class GamesMenu
    {
        public static void Show()
        {
            int selection = 0;
            bool invalidSelection = false;
            do
            {
                HeaderMenu.Show();
                Console.WriteLine("You are at: > Games");
                Console.WriteLine("");
                Console.WriteLine("GAMES");

                if (invalidSelection)
                {
                    Console.WriteLine("");
                    Console.WriteLine("!INVALID SELECTION!");
                    Console.WriteLine("");
                }

                Console.WriteLine("");
                Console.WriteLine("1) List all games");
                Console.WriteLine("2) Add new game");
                Console.WriteLine("3) Update existing game");
                Console.WriteLine("4) Delete game");
                Console.WriteLine("0) Return to main menu");

                Console.WriteLine("");
                Console.Write("Please, input your selection: ");
                selection = Convert.ToInt32(Console.ReadLine());

                invalidSelection = false;

                switch (selection)
                {
                    case 1:
                        ListGames();
                        break;
                    case 2:
                        AddGame();
                        break;
                    case 3:
                        UpdateGame();
                        break;
                    case 4:
                        DeleteGame();
                        break;
                    case 0:
                        //MainMenu.Show();
                        break;
                    default:
                        invalidSelection = true;
                        break;
                }
            }
            while (selection != 0);
        }


        public static void ListGames()
        {
            HeaderMenu.Show();
            Console.WriteLine("You are at: > Games > List all games");
            Console.WriteLine("");

            Console.WriteLine($"╔{new string('═', 109)}╗");
            Console.WriteLine($"║ GAMES LIST{new string(' ', 98)}║");
            Console.WriteLine($"╠═{new string('═', 3)}═╦═{new string('═', 20)}═╦═{new string('═', 40)}═╦═{new string('═', 10)}═╦═{new string('═', 10)}═╦═{new string('═', 9)}═╣");
            Console.WriteLine($"║ {"ID",-3} ║ {"Category",-20} ║ {"Title",-40} ║ {"Console",-10} ║ {"Stock qty.",-10} ║ {"Price",-9} ║");
            Console.WriteLine($"╠═{new string('═', 3)}═╬═{new string('═', 20)}═╬═{new string('═', 40)}═╬═{new string('═', 10)}═╬═{new string('═', 10)}═╬═{new string('═', 9)}═╣");

            foreach (var game in GamesRepository.List())
            {
                Console.WriteLine($"║ {game.ID,3} ║ {game.Category,-20} ║ {game.Title,-40} ║ {game.Console,-10} ║ {game.StockQuantity,10} ║ {game.Price,9:N2} ║");
            }

            Console.WriteLine($"╚═{new string('═', 3)}═╩═{new string('═', 20)}═╩═{new string('═', 40)}═╩═{new string('═', 10)}═╩═{new string('═', 10)}═╩═{new string('═', 9)}═╝");

            Console.WriteLine("");
            Console.WriteLine("Press any key to return to games main menu...");
            Console.ReadKey();

            //Show();
        }

        public static void AddGame()
        {
            HeaderMenu.Show();
            Console.WriteLine("You are at: > Games > New game");
            Console.WriteLine("");

            Game game = new Game();

            Console.WriteLine("Input product title: ");
            game.Title = Console.ReadLine();

            Console.Write("Input product price: ");
            game.Price = Convert.ToDecimal(Console.ReadLine());

            GamesRepository.Insert(game);

            Console.WriteLine("");
            Console.WriteLine("Product inserted successfully!");

            Console.WriteLine("");
            Console.WriteLine("Press any key to return to games main menu...");
            Console.ReadKey();

            //Show();
        }

        public static void UpdateGame()
        {
            HeaderMenu.Show();
            Console.WriteLine("You are at: > Games > Update games.");
            Console.WriteLine("");

            Console.Write("Type the ID of the game you want to update:");
            int id = Convert.ToInt32(Console.ReadLine());
            Game game = GamesRepository.Find(id);

            if (game != null)
            {              
                Console.WriteLine($"You have selected: {game.Title}");
                Console.WriteLine("");

                Console.Write("Type the new title of the game you want to update:");
                game.Title = Console.ReadLine();
                Console.WriteLine("");

                Console.Write("Type the new price of the game you want to update:");
                game.Price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                GamesRepository.Update(game);

                Console.WriteLine("");
                Console.WriteLine("Game updated successfully!");
                Console.WriteLine("");

                Console.WriteLine("Press any key to return.");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Error. Invalid ID.");
                Console.WriteLine("Press any key to return.");
                Console.ReadKey();
                return;
            }
        }

        public static void DeleteGame()
        {

        }
    }
}
