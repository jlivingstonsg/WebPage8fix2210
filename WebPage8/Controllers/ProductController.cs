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
        [BindProperties]
        public class SliderValue
        {
            public int Start { get; set; }
            public int End { get; set; }
        }
        private readonly IComputerService _computerService;
        public ProductController(IComputerService computerService)
        {
            _computerService = computerService;
        }
        public IActionResult Index(ComputerViewModel computerViewModel)
        {
            if (computerViewModel.Search != "")
            {                
                _computerService.FindBy(computerViewModel);                
            }
            return View("BrandItems", _computerService.All());
        }
        public IActionResult BrandItems(Category category)
        {
            ComputerViewModel computer = new ComputerViewModel { Search = category.Name };
            return View("BrandItems", _computerService.FindBy(computer));
        }
        public IActionResult Detail(int computerId)
        {
            ComputerViewModel computerViewModel = new ComputerViewModel { Computer = _computerService.FindBy(computerId) };
            return View("Detail", computerViewModel);
        }

        public IActionResult Search(int min, int max, string category)
        {
            ComputerViewModel computerViewModel = _computerService.FindBy(min, max, category);
            return PartialView("_PartialBrandItems", computerViewModel);
            //return new JsonResult(computerViewModel.Computers);
        }
        public IActionResult Items()
        {
            return View();
        }
    }
}
