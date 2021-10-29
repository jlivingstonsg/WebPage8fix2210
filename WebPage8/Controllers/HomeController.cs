using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebPage8.Models;
using WebPage8.Services;
using WebPage8.ViewModels;

namespace WebPage8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IComputerService _computerService;

        public HomeController(ICategoryService categoryService, IComputerService computerService)
        {
            _categoryService = categoryService;
            _computerService = computerService;
        }

        public IActionResult Index(CategoryViewModel categoryViewModel)
        {
            if (!string.IsNullOrEmpty(categoryViewModel.Search))
            {
                ComputerViewModel computerViewModel = _categoryService.FindByBrand(categoryViewModel);
                return View("BrandItems", computerViewModel);
            }
            else
            {
                return View(_categoryService.All());
            }
        }

        public IActionResult ProductList()
        {
            return View(_computerService.All());
        }

        public IActionResult CustomerService()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
