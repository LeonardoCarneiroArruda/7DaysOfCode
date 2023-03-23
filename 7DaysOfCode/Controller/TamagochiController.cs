using _7DaysOfCode.Application.Interfaces;
using _7DaysOfCode.Application.Services;
using _7DaysOfCode.Domain.Model;
using AutoMapper;

namespace _7DaysOfCode.Controller
{
    public class TamagochiController
    {
        private readonly IPokemonService pokemonService = new PokemonService();
        private readonly IMenuService menuService = new MenuService();
        private PersonModel pessoa;
        private readonly IMapper _mapper;

        public TamagochiController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task PlayGame()
        {
            string Nome = menuService.GetNameUser();
            pessoa = new PersonModel(Nome);
            string optionMenu = string.Empty;

            do
            {
                optionMenu = menuService.ShowOptionMenu(pessoa.Name);

                switch (optionMenu)
                {
                    case "1":
                        await this.ToAdoptMenu();
                        break;

                    case "2":
                        this.AdoptedMenu();
                        break;
                    case "3":
                        optionMenu = string.Empty;
                        break;
                }
            } while (optionMenu != string.Empty);
        }

        private async Task ToAdoptMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Escolha uma espécie: ");
            var allPokemons = await pokemonService.GetAllPokemonAsync();

            foreach (PokemonItemModel item in allPokemons.Results)
            {
                Console.WriteLine(item.ToString());
            }

            string pokemonEscolhido = Console.ReadLine();
            string optionMenuPokemon = string.Empty;
            do
            {

                optionMenuPokemon = menuService.ShowOptionsPokemon(pessoa.Name, pokemonEscolhido);
                var pokemonResponseApi = await pokemonService.GetPokemonByNameAsync(pokemonEscolhido);
                PokemonModel pokemon = _mapper.Map<PokemonModel>(pokemonResponseApi);

                switch (optionMenuPokemon)
                {
                    case "1":
                        pokemon.MostrarCaracteristicas();
                        break;

                    case "2":
                        pessoa.ToAdoptPokemon(pokemon);
                        Console.Write($"{pessoa.Name}, {pokemon.Name} ADOTADO COM SUCESSO!!!!");
                        Console.WriteLine();
                        optionMenuPokemon = string.Empty;
                        break;

                    case "3":
                        optionMenuPokemon = string.Empty;
                        break;
                }

            } while (optionMenuPokemon != string.Empty);
        }

        private void AdoptedMenu()
        {
            pessoa.ShowAdopted();

            Console.WriteLine("Se quiser interajir com algum pokemon, digite o nome, ou pressione enter para seguir: ");
            string pokemonInteract = Console.ReadLine();
            string optionMenuInteractPokemon = string.Empty;
            var pokemonAdopted = pessoa.Adopted.FirstOrDefault(p => p.Name == pokemonInteract);

            if (!string.IsNullOrWhiteSpace(pokemonInteract))
            {
                do
                {
                    optionMenuInteractPokemon = menuService.ShowOptionsInteractPokemon(pessoa.Name, pokemonInteract);

                    switch (optionMenuInteractPokemon)
                    {
                        case "1":
                            pokemonAdopted.MostrarCaracteristicas();
                            break;

                        case "2":
                            pokemonAdopted.Eat();
                            break;

                        case "3":
                            pokemonAdopted.Play();
                            break;

                        case "4":
                            optionMenuInteractPokemon = string.Empty;
                            break;
                    }

                } while (optionMenuInteractPokemon != string.Empty);
            }
        }

    }
}
