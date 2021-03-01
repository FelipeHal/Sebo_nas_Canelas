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
                        MainMenu.Show();
                        break;
                    default:
                        invalidSelection = true;
                        break;
                }
            }
            while (selection < 1 || selection > 4);
        }


        public static void ListGames()
        {
            HeaderMenu.Show();
            Console.WriteLine("You are at: > Games > List all games");
            Console.WriteLine("");

            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ GAMES LIST                                                                                                  ║");
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
            Show();
        }

        public static void AddGame()
        {

        }

        public static void UpdateGame()
        {

        }

        public static void DeleteGame()
        {

        }
    }
}
