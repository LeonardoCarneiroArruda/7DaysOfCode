using _7DaysOfCode.Domain.Model;
using _7DaysOfCode.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DaysOfCode.Application.Interfaces
{
    public interface IPokemonService
    {
        Task<GetAllPokemonResponse> GetAllPokemonAsync();
        Task<PokemonModel> GetPokemonByNameAsync(string name);
    }
}
