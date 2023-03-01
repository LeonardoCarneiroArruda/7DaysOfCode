using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DaysOfCode.Domain.Model
{
    public class PersonModel
    {
        public PersonModel(string name)
        {
            Name = name;
            Adopted = new List<PokemonModel>();
        }

        public string Name { get; set; }
        public List<PokemonModel> Adopted { get; private set; }

        public void ToAdoptPokemon(PokemonModel pokemon)
        {
            Adopted.Add(pokemon);
        }

        public void ShowAdopted()
        {
            Console.WriteLine("Pokemons adotados: ");
            foreach(var item in Adopted)
            {
                item.MostrarCaracteristicas();
            }
        }
    }
}
