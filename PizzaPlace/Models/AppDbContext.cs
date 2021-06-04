using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Pizza> Pizzas { get; set; }

        public DbSet<Category> Categories { get; set; }

        // seed data if no data in db
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Cheese"});
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Vegan" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Sea" });

            // seed pizza's
            modelBuilder.Entity<Pizza>().HasData(
                                new Pizza
                                {
                                    PizzaId = 1,
                                    Name = "Bologna",
                                    Price = 15.95M,
                                    ShortDescription = "Italian",
                                    LongDescription = "Ricotta, mozzarella, mortadella, pesto pistachio",
                                    CategoryId = 1,
                                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                                    InStock = true,
                                    IsPizzaOfTheWeek = false,
                                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                                    AllergyInformation = ""
                                }
            );
        }
    }
}
