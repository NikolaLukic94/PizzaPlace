using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly AppDbContext __appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            __appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => __appDbContext.Categories;
    }
}
