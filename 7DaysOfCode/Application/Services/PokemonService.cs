using _7DaysOfCode.Application.Interfaces;
using _7DaysOfCode.Domain.Model;
using _7DaysOfCode.Domain.Response;
using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DaysOfCode.Application.Services
{
    public class PokemonService : IPokemonService
    {
        public  async Task<GetAllPokemonResponse> GetAllPokemonAsync()
        {
            return await Consts.URLPokeApi
                  .AppendPathSegment("pokemon")
                  .GetJsonAsync<GetAllPokemonResponse>();
        }

        public async Task<PokemonResponse> GetPokemonByNameAsync(string name)
        {
            try
            {
                return await Consts.URLPokeApi
                                   .AppendPathSegment($"pokemon/{name}")
                                   .GetJsonAsync<PokemonResponse>();
            }
            catch (Exception)
            {
                
                return new PokemonResponse() { Success = false};
            }
        }
    }
}
