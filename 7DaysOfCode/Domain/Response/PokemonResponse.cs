using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DaysOfCode.Domain.Response
{
    public class PokemonResponse
    {

        public int Id { get; set; }
        public List<AbilitiesResponse> Abilities { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

    }


}
