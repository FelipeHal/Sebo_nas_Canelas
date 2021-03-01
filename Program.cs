using Sebo_nas_Canelas_3.Menus;
using System;

namespace Sebo_nas_Canelas_3
{
    class Program
    {
        static void Main(string[] args)
        {
            HeaderMenu.Show();

            Console.WriteLine("Seja bem vindo! Digite o nome de usuário:");
            
            string name = Convert.ToString(Console.ReadLine());
            MainMenu.SetUsername(name);

            MainMenu.Show();
        }
    }
}