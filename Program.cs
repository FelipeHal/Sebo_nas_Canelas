using System;
using System.Collections.Generic;

namespace Sebo_nas_Canelas_3
{
    class Program
    {
        static void Main(string[] args)
        {


            bool opcaoInvalida = false;
            Header();
            Console.WriteLine("Seja bem vindo! Digite o nome de usuário:");
            string name = Convert.ToString(Console.ReadLine());

            do
            {
                Header();
                Console.WriteLine("");
                Console.WriteLine($"Olá, {name}, o que gostaria de fazer?");

                Console.WriteLine("1) Consultar estilos literários.");
                Console.WriteLine("2) Consultar tipos de jogos.");
                Console.WriteLine("3) Consultar nome de livro.");
                Console.WriteLine("4) Consultar nome de jogo.");
                Console.WriteLine("5) Consultar estoque.");
                Console.WriteLine("6) Sair.");
                int opcao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine($"Você selecionou a opção {opcao}.");

                if (opcao == 1)
                {
                    Header();
                    Option1_ComList();
                    
                }

                else if (opcao == 2)
                {
                    Header();
                    Option2_ComList();
                }

                else if (opcao == 3)
                {
                    Header();
                    Option3_ComList();                    
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
                    Header();
                    Option4_ComList();                    
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
                else if (opcao == 5)
                {
                    Header();
                    Option5_ComList();                    
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

        static void Option1_ComList()
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

        static void Option2_ComList()
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

        static void Option3_ComList()
        {
            Console.WriteLine("");
            Console.WriteLine("Atualização manual dos registros em andamento. Dados indisponíveis no momento.");
            Console.WriteLine("");
            Console.WriteLine("Podemos ajudá-lo com algo mais?");
            Console.WriteLine("1) Sim, por favor.");
            Console.WriteLine("2) Não, obrigado.");
            //opcao = Convert.ToInt32(Console.ReadLine());
            //if (opcao == 1)
            //{
            //    opcaoInvalida = true;
            //}
            //else if (opcao == 2)
            //{
            //   opcaoInvalida = false;
            //    Console.WriteLine("");
            //    Console.WriteLine("Esperamos que tenha conseguido realizar seu atendimento. Obrigado e volte sempre!");
            //}
        }

        static void Option4_ComList()
        {
            Console.WriteLine("");
            Console.WriteLine("Atualização manual dos registros em andamento. Dados indisponíveis no momento.");
            Console.WriteLine("");
            Console.WriteLine("Podemos ajudá-lo com algo mais?");
            Console.WriteLine("1) Sim, por favor.");
            Console.WriteLine("2) Não, obrigado.");
        }

        static void Option5_ComList()
        {
            Console.WriteLine("");
            Console.WriteLine("Atualização manual dos registros em andamento. Dados indisponíveis no momento.");
            Console.WriteLine("");
            Console.WriteLine("Podemos ajudá-lo com algo mais?");
            Console.WriteLine("1) Sim, por favor.");
            Console.WriteLine("2) Não, obrigado.");
        }

        static void Header ()
        {
            Console.Clear();
            Console.WriteLine("   ##########################");
            Console.WriteLine("  ########   SEBO   ########");
            Console.WriteLine(" ######   NAS CANELAS   ###");
            Console.WriteLine("##########################");
        }
    }
}