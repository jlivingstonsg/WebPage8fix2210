using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage8.Models;
using WebPage8.Services;
using WebPage8.ViewModels;

namespace WebPage8.Controllers
{
    public class ProductController : Controller
    {
        private readonly IComputerService _computerService;
        public ProductController(IComputerService computerService)
        {
            _computerService = computerService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BrandItems(Category category)
        {
            ComputerViewModel computer = new ComputerViewModel { Search = category.Name };
            return View(_computerService.FindBy(computer));
        }
        public IActionResult Detail(int computerId)
        {
            ComputerViewModel computerViewModel = new ComputerViewModel { Computer = _computerService.FindBy(computerId) };
            return View("Detail", computerViewModel);
        }
        public IActionResult Items()
        {
            return View();
        }       
    }
}
