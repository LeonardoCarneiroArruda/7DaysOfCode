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
        }

        public int Id { get; set; }
        public List<AbilitiesModel> Abilities { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public void MostrarCaracteristicas()
        {
            Console.WriteLine();
            Console.WriteLine($"Nome Pokemon: {Name}");
            Console.WriteLine($"Altura: {Height}");
            Console.WriteLine($"Peso: {Weight}");
            Console.WriteLine($"Habilidades: ");
            Abilities.ForEach(a => Console.WriteLine(a.Ability.Name.ToUpper()));
            Console.WriteLine();
        }
    }

    
}
