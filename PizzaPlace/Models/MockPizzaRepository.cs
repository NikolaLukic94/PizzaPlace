using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{
    public class MockPizzaRepository : IPizzaRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pizza> AllPizzas => 
            new List<Pizza>
            {
                new Pizza {
                    PizzaId=1, 
                    Name="Bologna", 
                    Price=15.95M, 
                    ShortDescription="Italian", 
                    LongDescription="Ricotta, mozzarella, mortadella, pesto pistachio", 
                    Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", 
                    InStock=true, 
                    IsPizzaOfTheWeek=false, 
                    ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"
                },
          
            };

        public IEnumerable<Pizza> PizzaOfTheWeek { get; }

        public Pizza GetPizzaById(int PizzaId)
        {
            return AllPizzas.FirstOrDefault(p => p.PizzaId == PizzaId);
        }
    }
}
