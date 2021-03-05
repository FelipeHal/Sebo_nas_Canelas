using Sebo_nas_Canelas_3.AppObjects;
using Sebo_nas_Canelas_3.Menus.Books;
using Sebo_nas_Canelas_3.Menus.Games;
using Sebo_nas_Canelas_3.Menus.Magazines;
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
            int opcao = 0;
            bool opcaoInvalida = false;
            do
            {
                Header();
                Console.WriteLine("");
                Console.WriteLine($"Olá, o que gostaria de fazer?");

                if (opcaoInvalida)
                {
                    Console.WriteLine("");
                    Console.WriteLine("!INVALID SELECTION!");
                    Console.WriteLine("");
                }

                Console.WriteLine("1) Consultar estilos literários.");
                Console.WriteLine("2) Consultar tipos de jogos.");
                Console.WriteLine("3) Listar livros.");
                Console.WriteLine("4) Listar jogos.");
                Console.WriteLine("5) Listar revistas.");
                Console.WriteLine("6) Sair.");
                opcao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine($"Você selecionou a opção {opcao}.");

                opcaoInvalida = false;

                switch (opcao)
                { 
                    case 1:
                        Header();
                        Option1();
                        break;

                    case 2:
                        Header();
                        Option2();
                        break;

                    case 3:
                        BooksMenu.Show();
                        break;

                    case 4:
                        GamesMenu.Show();
                        break;

                    case 5:
                        MagazinesMenu.Show();
                        break;

                    case 6:
                        Console.WriteLine("");
                        Console.WriteLine("Esperamos que tenha conseguido realizar seu atendimento. Obrigado e volte sempre!");
                        break;
                    default:
                        opcaoInvalida = true;
                        break;

                }
                //if (opcao == 1)
                //{
                //    Header();
                //    Option1();
                //
                //}

                //else if (opcao == 2)
                //{
                //    Header();
                //    Option2();
                //}

                //else if (opcao == 3)
                //{
                //    BooksMenu.Show();
                
                //}
                //else if (opcao == 4)
                //{
                //    GamesMenu.Show();
                //}
                //else if (opcao == 5)
                //{
                //    MagazinesMenu.Show();
                    
                //}
                //else if (opcao == 6)
                //{
                //    Console.WriteLine("");
                //    Console.WriteLine("Esperamos que tenha conseguido realizar seu atendimento. Obrigado e volte sempre!");
                //}
                //else
                //{ opcaoInvalida = true; }
            }

            while (opcao < 1 || opcao > 6);



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
