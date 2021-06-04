using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly AppDbContext __appDbContext;

        public PizzaRepository(AppDbContext appDbContext)
        {
            __appDbContext = appDbContext;
        }

        public IEnumerable<Pizza> AllPizzas
        {
            get
            {
                return __appDbContext.Pizzas.Include(c => c.Category);
            }
        }

        public IEnumerable<Pizza> PizzaOfTheWeek
        { 
            get
            {
                return __appDbContext.Pizzas.Include(c => c.Category).Where(p => p.IsPizzaOfTheWeek);
            }
        }


        public Pizza GetPizzaById(int PizzaId)
        {
            return __appDbContext.Pizzas.FirstOrDefault(p => p.PizzaId == PizzaId);
        }
    }
}
