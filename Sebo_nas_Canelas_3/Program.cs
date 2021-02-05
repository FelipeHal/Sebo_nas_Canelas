using System;

namespace Sebo_nas_Canelas_3
{
    class Program
    {
        static void Main(string[] args)
        {


            bool opcaoInvalida = false;
            Console.WriteLine("Seja bem vindo! Digite o nome de usuário:");
            string name = Convert.ToString(Console.ReadLine());

            do
            {
                Console.WriteLine("");
                Console.WriteLine($"Olá, {name}, o que gostaria de fazer?");

                Console.WriteLine("1) Consultar estilos literários.");
                Console.WriteLine("2) Consultar tipos de jogos.");
                Console.WriteLine("3) Consultar nome de livro.");
                Console.WriteLine("4) Consultar nome de jogo.");
                Console.WriteLine("5) Consultar estoque.");
                Console.WriteLine("6) Sair.");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine($"Você selecionou a opção {number}.");

                if (number == 1)
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

                    Console.WriteLine("Por favor, digite três estilos que deseja consultar:");

                    string[] estilos = new string[3];
                    foreach (string estilo in estilos)
                    {
                        for (int i = 0; i < estilos.Length; i++)
                        {
                            estilos[i] = Console.ReadLine();

                        }

                        Console.WriteLine("");
                        Console.WriteLine("Os estilos que você deseja consultar são: ");
                        Console.WriteLine("");

                        for (int i = 0; i < estilos.Length; i++)
                        {
                            Console.WriteLine(estilos[i]);

                        }
                    }
                        
                    //if (resposta == "S")
                    //{
                    //  for (int a = 0; a < estilos.Length; a++)
                    //  {
                    //      Console.WriteLine("Estilos que deseja consultar: " + estilos[a]);
                    //  }
                    //    
                    //}
                    //else
                    //{
                    //  Console.WriteLine("Podemos ajudá-lo com algo mais?");
                    //Console.WriteLine("1) Sim, por favor.");
                    //Console.WriteLine("2) Não, obrigado.");
                    //number = Convert.ToInt32(Console.ReadLine());
                    //if (number == 1)
                    //{
                    //opcaoInvalida = true;
                    //}
                    //else if (number == 2)
                    //{
                    //opcaoInvalida = false;
                    //Console.WriteLine("");
                    //Console.WriteLine("Esperamos que tenha conseguido realizar seu atendimento. Obrigado e volte sempre!");
                    // }
                    //}

                    //Console.WriteLine("Você deseja consultar os estilos:");
                    //for (i = 0; i < estilos.Length ; i++)
                    //   { Console.WriteLine($"1º estilo: {estilos[i]}"); }




                }

                else if (number == 2)
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

                else if (number == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Atualização manual dos registros em andamento. Dados indisponíveis no momento.");
                    Console.WriteLine("");
                    Console.WriteLine("Podemos ajudá-lo com algo mais?");
                    Console.WriteLine("1) Sim, por favor.");
                    Console.WriteLine("2) Não, obrigado.");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number == 1)
                    {
                        opcaoInvalida = true;
                    }
                    else if (number == 2)
                    {
                        opcaoInvalida = false;
                        Console.WriteLine("");
                        Console.WriteLine("Esperamos que tenha conseguido realizar seu atendimento. Obrigado e volte sempre!");
                    }
                }
                else if (number == 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Atualização manual dos registros em andamento. Dados indisponíveis no momento.");
                    Console.WriteLine("");
                    Console.WriteLine("Podemos ajudá-lo com algo mais?");
                    Console.WriteLine("1) Sim, por favor.");
                    Console.WriteLine("2) Não, obrigado.");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number == 1)
                    {
                        opcaoInvalida = true;
                    }
                    else if (number == 2)
                    {
                        opcaoInvalida = false;
                        Console.WriteLine("");
                        Console.WriteLine("Esperamos que tenha conseguido realizar seu atendimento. Obrigado e volte sempre!");
                    }
                }
                else if (number == 5)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Atualização manual dos registros em andamento. Dados indisponíveis no momento.");
                    Console.WriteLine("");
                    Console.WriteLine("Podemos ajudá-lo com algo mais?");
                    Console.WriteLine("1) Sim, por favor.");
                    Console.WriteLine("2) Não, obrigado.");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number == 1)
                    {
                        opcaoInvalida = true;
                    }
                    else if (number == 2)
                    {
                        opcaoInvalida = false;
                        Console.WriteLine("");
                        Console.WriteLine("Esperamos que tenha conseguido realizar seu atendimento. Obrigado e volte sempre!");
                    }
                }
                else if (number == 6)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Esperamos que tenha conseguido realizar seu atendimento. Obrigado e volte sempre!");
                }
                else
                { opcaoInvalida = true; }
            }

            while (opcaoInvalida);



        }
    }
}
