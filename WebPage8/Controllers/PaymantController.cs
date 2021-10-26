using Microsoft.AspNetCore.Mvc;
using System;
using Stripe;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPage8.Controllers
{
    public class PaymantController : Controller
    {
        public PaymantController()
        {
            StripeConfiguration.ApiKey = "sk_test_51I6bvkHTHUtbDw8mkUTk68c6Vgv5BivdJLpbD1mL4Rt31id6jbfZhc3gUBozyEXB8CnhoRIDuwXxbzyWorxxlpVZ00ycZwM2Ih";
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
