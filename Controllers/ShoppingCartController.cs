using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timups.Data.Interfaces;
using Timups.Models;
using Timups.ViewModels;

namespace Timups.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IWatchRepository _watchRepository;
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartController(IWatchRepository watchRepository, ShoppingCart shoppingCart)
        {
            _watchRepository = watchRepository;
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

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart (int watchId)
        {
            var selectedWatch = _watchRepository.Watches.FirstOrDefault(p => p.WatchId == watchId);
            if (selectedWatch != null)
            {
                _shoppingCart.AddToCart(selectedWatch, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int watchId)
        {
            var selectedWatch = _watchRepository.Watches.FirstOrDefault(p => p.WatchId == watchId);
            if (selectedWatch != null)
            {
                _shoppingCart.RemoveFromCart(selectedWatch);
            }
            return RedirectToAction("Index");
        }
    }
}
