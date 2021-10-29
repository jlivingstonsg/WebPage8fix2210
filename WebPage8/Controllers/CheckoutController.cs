using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage8.Data;

// stripe docs => get started => Accept online payment
namespace WebPage8.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ShoppingCart _shoppingCart;
        public CheckoutController(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }
        public ActionResult Create()
        {
            var urlOrigin = "https://" + Request.Host.ToString();

            var options = new SessionCreateOptions
            {
                LineItems = new List<SessionLineItemOptions>
            {
                new SessionLineItemOptions
                {
                    
                Amount = Convert.ToInt32(_shoppingCart.GetShoppingCartTotal()) * 100,
                Currency= "sek",
                Name = _shoppingCart.ShoppingCartId,
                Quantity = 1,
                },
            },
                PaymentMethodTypes = new List<string>
            {
                "card",
            },
                Mode = "payment",
                SuccessUrl = urlOrigin + "/ShoppingCart/PaymentNotification",
                CancelUrl = urlOrigin + "/ShoppingCart",
            };
            var service = new SessionService();
            Session session = service.Create(options);
            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);
        }
    }
}
