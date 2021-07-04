using Microsoft.AspNetCore.Mvc;
using PizzaPlace.Models;
using PizzaPlace.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IPizzaRepository _pizzaRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IPizzaRepository pizzaRepository, ShoppingCart shoppingCart)
        {
            _pizzaRepository = pizzaRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()

            };

            return ViewResult(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int pizzaId)
        {
            var selectedPizza = _pizzaRepository.AllPizzas.FirstOrDefault(p => p.PizzaId == pizzaId);

            if (selectedPizza !== null)
            {
            _shoppingCart.AddToCart(selectedPizza, 1);
            }

            return RedirectToAction("Index");
            
        }

        public RedirectToActionResult RemoveFromShoppingCart(int pizzaId)
        {
            var selectedPizza = _pizzaRepository.AllPizzas.FirstOrDefault(p => p.PizzaId == pizzaId);

            if (selectedPizza !== null)
            {
                _shoppingCart.RemoveFromCart(selectedPizza);
            }

            return RedirectToActionResult("Index");
        }

        
    }
}
