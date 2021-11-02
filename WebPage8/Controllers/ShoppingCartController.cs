using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage8.Data;
using WebPage8.ViewModels;

namespace WebPage8.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IComputerRepo _computerRepo;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IComputerRepo computerRepo, ShoppingCart shoppingCart)
        {
            _computerRepo = computerRepo;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            ShoppingCartViewModel shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddtoShoppingCart(int computerId)
        {
            var selectedComputer = _computerRepo.Read()
                .FirstOrDefault(c => c.ComputerId == computerId);

            if(selectedComputer != null)
            {
                _shoppingCart.AddToCart(selectedComputer, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int computerId)
        {
            var selectedComputer = _computerRepo.Read()
                .FirstOrDefault(c => c.ComputerId == computerId);

            if(selectedComputer != null)
            {
                _shoppingCart.RemoveFromCart(selectedComputer);
            }
            return RedirectToAction("Index");
        }

        public IActionResult PaymentNotification()
        {
            _shoppingCart.MarkAsPaid();
            return View("PaymentNotification");
        }
    }
}
