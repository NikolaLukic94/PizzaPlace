using PizzaPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pizza> PizzaOfTheWeek { get; set; }
    }
}
