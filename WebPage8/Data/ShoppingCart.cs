using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage8.Models;

namespace WebPage8.Data
{
    public class ShoppingCart
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public string ShoppingCartId { get; set; }

        //public Category ComputerCategory { get; set; }
        public List<ComputerOrder> ShoppingCartItems { get; set; }


        private ShoppingCart(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }        

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<ApplicationDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Computer computer, decimal Quantity)
        {
            var shoppingCartItem = _applicationDbContext.ComputerOrders.SingleOrDefault(
                c => c.Computer.ComputerId == computer.ComputerId &&
                c.ShoppingCartId == ShoppingCartId);
            

            if(shoppingCartItem == null)
            {
                shoppingCartItem = new ComputerOrder
                {
                    ShoppingCartId = ShoppingCartId,
                    Computer = computer,
                    Quantity = 1
                };
                _applicationDbContext.ComputerOrders.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Quantity++;
            }

            //ComputerCategory = shoppingCartItem.Computer.Category; //for returning back view

            _applicationDbContext.SaveChanges();
        }

        public int RemoveFromCart(Computer computer)
        {
            var shoppingCartItem = _applicationDbContext.ComputerOrders.SingleOrDefault(
                c => c.Computer.ComputerId == computer.ComputerId &&
                c.ShoppingCartId == ShoppingCartId);

            var localQuantity = 0;
            if(shoppingCartItem != null)
            {
                if(shoppingCartItem.Quantity > 1)
                {
                    shoppingCartItem.Quantity--;
                    localQuantity = shoppingCartItem.Quantity;
                }
                else
                {
                    _applicationDbContext.ComputerOrders.Remove(shoppingCartItem);
                }
            }
            _applicationDbContext.SaveChanges();
            return localQuantity;
        }

        public List<ComputerOrder> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                (ShoppingCartItems = _applicationDbContext.ComputerOrders
                    .Where(c => c.ShoppingCartId == ShoppingCartId)
                    .Include(a => a.Computer)
                    .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _applicationDbContext.ComputerOrders
                .Where(c => c.ShoppingCartId == ShoppingCartId);             

            _applicationDbContext.ComputerOrders.RemoveRange(cartItems);

            _applicationDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _applicationDbContext.ComputerOrders
                .Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Computer.Price * c.Quantity).Sum();

            return total;
        }
    }
}
