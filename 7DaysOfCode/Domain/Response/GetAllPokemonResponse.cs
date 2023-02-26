using _7DaysOfCode.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DaysOfCode.Domain.Response
{
    public class GetAllPokemonResponse
    {

        public int Count { get; set; }

        public string Next { get; set; }

        public List<PokemonItemModel> Results { get; set; }
    }
}
