using Microsoft.AspNetCore.Mvc;
using PizzaPlace.Models;
using PizzaPlace.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaRepository _pizzaRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PizzaController(IPizzaRepository pizzaRepository, ICategoryRepository categoryRepository)
        {
            _pizzaRepository = pizzaRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PizzaListViewModel pizzaListViewModel = new PizzaListViewModel();

            pizzaListViewModel.Pizzas = _pizzaRepository.AllPizzas;
            pizzaListViewModel.CurrentCategory = "Cheese";

            return View(pizzaListViewModel);
        }

        public IActionResult Details(int id)
        {
            var pizza = _pizzaRepository.GetPizzaById(id);

            if (pizza == null)
                return NotFound();
            return View(pizza);
        }
    }
}
