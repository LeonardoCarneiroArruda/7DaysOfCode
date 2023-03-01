using _7DaysOfCode.Application.Interfaces;
using _7DaysOfCode.Application.Services;
using _7DaysOfCode.Domain.Model;


IPokemonService pokemonService = new PokemonService();
IMenuService menuService = new MenuService();
PersonModel pessoa;


string Nome = menuService.GetNameUser();
pessoa = new PersonModel(Nome);
string optionMenu = string.Empty;

do
{
    optionMenu = menuService.ShowOptionMenu(pessoa.Name);

    switch (optionMenu)
    {
        case "1":
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
                var pokemon = await pokemonService.GetPokemonByNameAsync(pokemonEscolhido);

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

            break;

        case "2":
            pessoa.ShowAdopted();
            break;
        case "3":
            optionMenu = string.Empty;
            break;
    }
} while (optionMenu != string.Empty);



