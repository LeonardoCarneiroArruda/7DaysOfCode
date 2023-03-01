using _7DaysOfCode.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DaysOfCode.Application.Services
{
    public class MenuService : IMenuService
    {
        public string GetNameUser()
        {
            Console.WriteLine("Qual o seu nome?");
            return Console.ReadLine();
        }

        public string ShowOptionMenu(string name)
        {
            Console.WriteLine("----------------MENU---------------");
            Console.WriteLine($"{name} você deseja:");
            Console.WriteLine("1 - Adotar um mascote virtual");
            Console.WriteLine("2 - Ver seus mascotes");
            Console.WriteLine("3 - Sair");
            return Console.ReadLine();
        }

        public string ShowOptionsPokemon(string person, string pokemon)
        {
            Console.WriteLine();
            Console.WriteLine($"{person} você deseja: ");
            Console.WriteLine($"1 - Saber mais sobre {pokemon}");
            Console.WriteLine($"2 - Adotar {pokemon}");
            Console.WriteLine($"3 - Voltar");
            return Console.ReadLine();
        }
    }
}
