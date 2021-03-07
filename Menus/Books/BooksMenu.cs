using Sebo_nas_Canelas_3.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Sebo_nas_Canelas_3.AppObjects;

namespace Sebo_nas_Canelas_3.Menus.Books
{
    public static class BooksMenu
    {
        public static void Show()
        {
            int selection = 0;
            bool invalidSelection = false;
            do
            {
                HeaderMenu.Show();
                Console.WriteLine("You are at: > Books");
                Console.WriteLine("");
                Console.WriteLine("BOOKS");

                if (invalidSelection)
                {
                    Console.WriteLine("");
                    Console.WriteLine("!INVALID SELECTION!");
                    Console.WriteLine("");
                }

                Console.WriteLine("");
                Console.WriteLine("1) List all books.");
                Console.WriteLine("2) Add new books.");
                Console.WriteLine("3) Update existing books.");
                Console.WriteLine("4) Delete books.");
                Console.WriteLine("0) Return to main menu.");

                Console.WriteLine("");
                Console.Write("Please, input your selection: ");
                selection = Convert.ToInt32(Console.ReadLine());

                invalidSelection = false;

                switch (selection)
                {
                    case 1:
                        ListBooks();
                        break;
                    case 2:
                        AddBook();
                        break;
                    case 3:
                        UpdateBook();
                        break;
                    case 4:
                        DeleteBook();
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


        public static void ListBooks()
        {
            HeaderMenu.Show();
            Console.WriteLine("You are at: > Books > List all books");
            Console.WriteLine("");

            Console.WriteLine($"╔{new string('═', 109)}╗");
            Console.WriteLine($"║ BOOKS LIST{new string(' ', 98)}║");
            Console.WriteLine($"╠═{new string('═', 3)}═╦═{new string('═', 20)}═╦═{new string('═', 40)}═╦═{new string('═', 10)}═╦═{new string('═', 10)}═╦═{new string('═', 9)}═╣");
            Console.WriteLine($"║ {"ID",-3} ║ {"Category",-20} ║ {"Title",-40} ║ {"Publisher",-10} ║ {"Stock qty.",-10} ║ {"Price",-9} ║");
            Console.WriteLine($"╠═{new string('═', 3)}═╬═{new string('═', 20)}═╬═{new string('═', 40)}═╬═{new string('═', 10)}═╬═{new string('═', 10)}═╬═{new string('═', 9)}═╣");

            foreach (var book in BooksRepository.List())
            {
                Console.WriteLine($"║ {book.ID,3} ║ {book.Category,-20} ║ {book.Title,-40} ║ {book.Publisher,-10} ║ {book.StockQuantity,10} ║ {book.Price,9:N2} ║");
            }

            Console.WriteLine($"╚═{new string('═', 3)}═╩═{new string('═', 20)}═╩═{new string('═', 40)}═╩═{new string('═', 10)}═╩═{new string('═', 10)}═╩═{new string('═', 9)}═╝");

            Console.WriteLine("");
            Console.WriteLine("Press any key to return to books main menu...");
            Console.ReadKey();
            Show();
        }

        public static void AddBook()
        {
            HeaderMenu.Show();
            Console.WriteLine("You are at: > Books > Add new book.");
            Console.WriteLine("");

            Book book = new Book();

                
            Console.WriteLine("Type the title of the book you want to add.");
            book.Title = Console.ReadLine();
            
                        
            Console.WriteLine("Type the price of the book you want to add.");
            book.Price = Convert.ToDecimal(Console.ReadLine());

            BooksRepository.Insert(book);

            Console.WriteLine("");
            Console.WriteLine("Book inserted successfully!");
            Console.WriteLine("");

            Console.WriteLine("Press any key to return.");
            Console.ReadKey();



        }

        public static void UpdateBook()
        {

            Book book = BooksRepository.Find(50000);
            if (book != null)
            {
                //Update book
            }
            else
            {
                //Invalid ID, show error
            }

        }

        public static void DeleteBook()
        {

        }
    }
}
