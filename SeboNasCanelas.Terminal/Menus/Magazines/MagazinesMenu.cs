using Sebo_nas_Canelas_3.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Sebo_nas_Canelas_3.AppObjects;

namespace Sebo_nas_Canelas_3.Menus.Magazines
{
    public static class MagazinesMenu
    {
        public static void Show()
        {
            int selection = 0;
            bool invalidSelection = false;
            do
            {
                HeaderMenu.Show();
                Console.WriteLine("You are at: > Magazines");
                Console.WriteLine("");
                Console.WriteLine("MAGAZINES");

                if (invalidSelection)
                {
                    Console.WriteLine("");
                    Console.WriteLine("!INVALID SELECTION!");
                    Console.WriteLine("");
                }

                Console.WriteLine("");
                Console.WriteLine("1) List all magazines.");
                Console.WriteLine("2) Add new magazine.");
                Console.WriteLine("3) Update existing magazine.");
                Console.WriteLine("4) Delete magazine");
                Console.WriteLine("0) Return to main menu");

                Console.WriteLine("");
                Console.Write("Please, input your selection: ");
                selection = Convert.ToInt32(Console.ReadLine());

                invalidSelection = false;

                switch (selection)
                {
                    case 1:
                        ListMagazine();
                        break;
                    case 2:
                        AddMagazine();
                        break;
                    case 3:
                        UpdateMagazine();
                        break;
                    case 4:
                        DeleteMagazine();
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


        public static void ListMagazine()
        {
            HeaderMenu.Show();
            Console.WriteLine("You are at: > Magazines > List all magazines");
            Console.WriteLine("");

            Console.WriteLine($"╔{new string('═', 109)}╗");
            Console.WriteLine($"║ MAGAZINES LIST{new string(' ', 94)}║");
            Console.WriteLine($"╠═{new string('═', 3)}═╦═{new string('═', 20)}═╦═{new string('═', 40)}═╦═{new string('═', 10)}═╦═{new string('═', 10)}═╦═{new string('═', 9)}═╣");
            Console.WriteLine($"║ {"ID",-3} ║ {"Category",-20} ║ {"Title",-40} ║ {"Publisher",-10} ║ {"Stock qty.",-10} ║ {"Price",-9} ║");
            Console.WriteLine($"╠═{new string('═', 3)}═╬═{new string('═', 20)}═╬═{new string('═', 40)}═╬═{new string('═', 10)}═╬═{new string('═', 10)}═╬═{new string('═', 9)}═╣");

            foreach (var magazine in MagazinesRepository.List())
            {
                Console.WriteLine($"║ {magazine.ID,3} ║ {magazine.Category,-20} ║ {magazine.Title,-40} ║ {magazine.Publisher,-10} ║ {magazine.StockQuantity,10} ║ {magazine.Price,9:N2} ║");
            }

            Console.WriteLine($"╚═{new string('═', 3)}═╩═{new string('═', 20)}═╩═{new string('═', 40)}═╩═{new string('═', 10)}═╩═{new string('═', 10)}═╩═{new string('═', 9)}═╝");

            Console.WriteLine("");
            Console.WriteLine("Press any key to return to magazines main menu...");
            Console.ReadKey();
            Show();
        }

        public static void AddMagazine()
        {
            HeaderMenu.Show();
            Console.WriteLine("You are at: > Magazines > Add new Magazine.");
            Console.WriteLine("");

            Magazine magazine = new Magazine();

            Console.Write("Insert magazine title:");
            magazine.Title = Console.ReadLine();

            Console.Write("Insert magazine price:");
            magazine.Price = Convert.ToDecimal(Console.ReadLine());

            MagazinesRepository.Insert(magazine);

            Console.WriteLine("");
            Console.WriteLine("Magazine inserted successfully!");

            Console.WriteLine("");
            Console.WriteLine("Press any key to return.");
            Console.ReadKey();




        }

        public static void UpdateMagazine()
        {
            HeaderMenu.Show();
            Console.WriteLine("You are at: > Magazines > Update magazines.");
            Console.WriteLine("");

            Console.Write("Type the ID of the magazine you want to update:");
            int id = Convert.ToInt32(Console.ReadLine());
            Magazine magazine = MagazinesRepository.Find(id);

            if (magazine != null)
            {
                Console.WriteLine($"You have selected: {magazine.Title}");
                Console.WriteLine("");

                Console.Write("Type the new title of the magazine you want to update:");
                magazine.Title = Console.ReadLine();
                Console.WriteLine("");

                Console.Write("Type the new price of the magazine you want to update:");
                magazine.Price = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("");

                MagazinesRepository.Update(magazine);

                Console.WriteLine("");
                Console.WriteLine("Magazine updated successfully!");
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

        public static void DeleteMagazine()
        {
            HeaderMenu.Show();
            Console.WriteLine("You are at: > Magazines > Delete magazines.");
            Console.WriteLine("");

            Console.Write("Type the ID of the magazine you want to delete:");
            int id = Convert.ToInt32(Console.ReadLine());
            Magazine magazine = MagazinesRepository.Find(id);

            if (magazine != null)
            {
                Console.WriteLine($"You have selected: {magazine.Title}");
                Console.WriteLine("");

                MagazinesRepository.Delete(magazine);

                Console.WriteLine("");
                Console.WriteLine("Magazine deleted successfully!");
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
    }
}