using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DaysOfCode.Domain.Model
{
    public class PokemonModel
    {
        public PokemonModel(int id, List<AbilitiesModel> abilities, int height, int weight, string name)
        {
            Id = id;
            Abilities = abilities;
            Height = height;
            Weight = weight;
            Name = name;

            Random randNum = new Random();
            Hunger = randNum.Next(1, 10);
            Humor = randNum.Next(1, 10);
        }

        public int Id { get; set; }
        public List<AbilitiesModel> Abilities { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        private int Hunger { get; set; }
        private int Humor { get; set; }

        public void MostrarCaracteristicas()
        {
            Console.WriteLine();
            Console.WriteLine($"Nome Pokemon: {Name}");
            Console.WriteLine($"Altura: {Height}");
            Console.WriteLine($"Peso: {Weight}");

            string statusHunger = Hunger < 6 ? $"{Name} está com fome" : $"{Name} está alimentado";
            string statusHumor = Humor < 6 ? $"{Name} está triste" : $"{Name} está feliz";

            Console.WriteLine(statusHunger);
            Console.WriteLine(statusHumor);

            Console.WriteLine($"Habilidades: ");
            Abilities.ForEach(a => Console.WriteLine(a.Ability.Name.ToUpper()));
            Console.WriteLine();
        }

        public void Play()
        {
            Humor++;
            Hunger--;
            Console.WriteLine("Mascote brincou");
        }

        public void Eat()
        {
            Humor--;
            Hunger++;
            Console.WriteLine("Mascote alimentado");
        }
    }

    
}
