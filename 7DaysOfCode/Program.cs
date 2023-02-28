using _7DaysOfCode.Application.Interfaces;
using _7DaysOfCode.Application.Services;
using _7DaysOfCode.Domain.Model;


IPokemonService pokemonService = new PokemonService();

var allPokemons = await pokemonService.GetAllPokemonAsync();

foreach (PokemonItemModel item in allPokemons.Results)
{
    Console.WriteLine(item.ToString());
    Console.WriteLine();
}

Console.WriteLine("Digite o nome de um pokemon para consulta de detalhes");
string pokemonEscolhido = Console.ReadLine();

while(pokemonEscolhido != "0")
{

    var pokemon = await pokemonService.GetPokemonByNameAsync(pokemonEscolhido);

    pokemon.MostrarCaracteristicas();

    Console.WriteLine("Digite o nome de um pokemon para consulta de detalhes ou digite 0 para sair: ");
    pokemonEscolhido = Console.ReadLine();
}



