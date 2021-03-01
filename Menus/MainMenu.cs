using Sebo_nas_Canelas_3.AppObjects;
using Sebo_nas_Canelas_3.Menus.Games;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sebo_nas_Canelas_3.Menus
{
    public class MainMenu
    {
        static string Username { get; set; }

        public static void SetUsername(string username)
        {
            Username = username;
        }



        public static void Show()
        {
            bool opcaoInvalida = false;
            do
            {
                Header();
                Console.WriteLine("");
                Console.WriteLine($"Olá, {Username}, o que gostaria de fazer?");

                Console.WriteLine("1) Consultar estilos literários.");
                Console.WriteLine("2) Consultar tipos de jogos.");
                Console.WriteLine("3) Listar livros.");
                Console.WriteLine("4) Listar jogos.");
                Console.WriteLine("5) Listar revistas.");
                Console.WriteLine("6) Sair.");
                int opcao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine($"Você selecionou a opção {opcao}.");

                if (opcao == 1)
                {
                    Header();
                    Option1();

                }

                else if (opcao == 2)
                {
                    Header();
                    Option2();
                }

                else if (opcao == 3)
                {
                    Header();
                    Option3();
                    opcao = Convert.ToInt32(Console.ReadLine());
                    if (opcao == 1)
                    {
                        opcaoInvalida = true;
                    }
                    else if (opcao == 2)
                    {
                        opcaoInvalida = false;
                        Console.WriteLine("");
                        Console.WriteLine("Esperamos que tenha conseguido realizar seu atendimento. Obrigado e volte sempre!");
                    }
                }
                else if (opcao == 4)
                {
                    GamesMenu.Show();
                }
                else if (opcao == 5)
                {
                    Header();
                    Option5();
                    opcao = Convert.ToInt32(Console.ReadLine());
                    if (opcao == 1)
                    {
                        opcaoInvalida = true;
                    }
                    else if (opcao == 2)
                    {
                        opcaoInvalida = false;
                        Console.WriteLine("");
                        Console.WriteLine("Esperamos que tenha conseguido realizar seu atendimento. Obrigado e volte sempre!");
                    }
                }
                else if (opcao == 6)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Esperamos que tenha conseguido realizar seu atendimento. Obrigado e volte sempre!");
                }
                else
                { opcaoInvalida = true; }
            }

            while (opcaoInvalida);



        }



        static void Option1()
        {
            Console.WriteLine("");
            Console.WriteLine("1)Biografia");
            Console.WriteLine("2)Contos");
            Console.WriteLine("3)Ficção Histórica");
            Console.WriteLine("4)Ficção Científica");
            Console.WriteLine("5)Fantasia");
            Console.WriteLine("6)Humor");
            Console.WriteLine("7)Infantojuvenis");
            Console.WriteLine("8)Literatura Brasileira");
            Console.WriteLine("9)Literatura Estrangeira");
            Console.WriteLine("10)Livros Raros");
            Console.WriteLine("11)Outros assuntos");

            Console.WriteLine("Por favor, digite os estilos que deseja consultar:");

            List<string> estilosList = new List<string>();
            string resposta;


            do
            {
                estilosList.Add(Console.ReadLine());


                Console.WriteLine("Deseja consultar outros estilos? (S/N)");
                resposta = Console.ReadLine();

            } while (resposta == "S");

            Console.WriteLine();
            Console.WriteLine("Os estilos que você deseja consultar são: ");
            Console.WriteLine();

            for (int i = 0; i < estilosList.Count; i++)
            {

                Console.WriteLine($"{i + 1}º estilo: {estilosList[i]}");
            }
        }

        static void Option2()
        {
            Console.WriteLine("");
            Console.WriteLine("1) Cooperativo");
            Console.WriteLine("2) Competitivo");
            Console.WriteLine("3) Dedução");
            Console.WriteLine("4) Educativo");
            Console.WriteLine("5) Enigma");
            Console.WriteLine("6) Estratégia");
            Console.WriteLine("7) RPG");
            Console.WriteLine("8) Card Game");
            Console.WriteLine("9) Outros");
        }

        static void Option3()
        {
            Console.WriteLine("");

            List<Book> books = Book.GetBooks();
            foreach (Book book in books)
            {
                Console.WriteLine(book.Title);
            }
            //Console.WriteLine("Atualização manual dos registros em andamento. Dados indisponíveis no momento.");
            Console.WriteLine("");
            Console.WriteLine("Podemos ajudá-lo com algo mais?");
            Console.WriteLine("1) Sim, por favor.");
            Console.WriteLine("2) Não, obrigado.");

        }

        static void Option5()
        {
            Console.WriteLine("");

            List<Magazine> magazines = Magazine.GetMagazines();
            foreach (Magazine magazine in magazines)
            {
                Console.WriteLine(magazine.Title);
            }
            //Console.WriteLine("Atualização manual dos registros em andamento. Dados indisponíveis no momento.");
            Console.WriteLine("");
            Console.WriteLine("Podemos ajudá-lo com algo mais?");
            Console.WriteLine("1) Sim, por favor.");
            Console.WriteLine("2) Não, obrigado.");
        }

        static void Header()
        {
            Console.Clear();
            Console.WriteLine("   ##########################");
            Console.WriteLine("  ########   SEBO   ########");
            Console.WriteLine(" ######   NAS CANELAS   ###");
            Console.WriteLine("##########################");
        }
    }
}
