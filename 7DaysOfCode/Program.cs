using _7DaysOfCode;
using _7DaysOfCode.Domain.Model;
using _7DaysOfCode.Domain.Response;
using Flurl;
using Flurl.Http;
using System;


var allPokemons = await Consts.URLPokeApi
                  .AppendPathSegment("pokemon")
                  .GetJsonAsync<GetAllPokemonResponse>();

foreach (PokemonItemModel item in allPokemons.Results)
{
    Console.WriteLine(item.ToString());
    Console.WriteLine();
}

Console.WriteLine("Insira o nome correspondente ao Pokemon que deseja ver as características: ");
string pokemonEscolhido = Console.ReadLine();

PokemonItemModel pokemon = allPokemons.Results.FirstOrDefault(p => p.Name == pokemonEscolhido);

string pokemonProperties = await Consts.URLPokeApi
                           .AppendPathSegment($"pokemon/{pokemonEscolhido}")
                           .GetStringAsync();

Console.WriteLine(pokemonProperties);

