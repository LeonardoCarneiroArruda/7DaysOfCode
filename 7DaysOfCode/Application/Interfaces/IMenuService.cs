using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DaysOfCode.Application.Interfaces
{
    public interface IMenuService
    {
        string GetNameUser();
        string ShowOptionMenu(string name);
        string ShowOptionsPokemon(string person, string pokemon);

    }
}
