using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Cheese", Description="Pizzas with cheese only"},
                new Category{CategoryId=2, CategoryName="Vegan", Description="Vegan-Pizzas"},
                new Category{CategoryId=3, CategoryName="Sea", Description="Sea Pizzas"}
            };
    }
}
