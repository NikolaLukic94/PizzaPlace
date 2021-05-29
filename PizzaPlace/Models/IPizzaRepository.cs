using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{
    public interface IPizzaRepository
    {
        IEnumerable<Pizza> AllPizzas { get; }

        IEnumerable<Pizza> PizzaOfTheWeek { get; }

        Pizza GetPizzaById(int PizzaId);
    }
}
