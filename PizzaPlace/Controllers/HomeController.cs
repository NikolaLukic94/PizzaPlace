using Microsoft.AspNetCore.Mvc;
using PizzaPlace.Models;
using PizzaPlace.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPizzaRepository _pizzaRepository;

        public HomeController(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PizzaOfTheWeek = _pizzaRepository.PizzaOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
