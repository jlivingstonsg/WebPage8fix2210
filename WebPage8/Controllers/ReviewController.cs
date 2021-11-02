using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage8.Data;
using WebPage8.Models;
using WebPage8.Services;
using WebPage8.ViewModels;

namespace WebPage8.Controllers
{
    //[Authorize]
    public class ReviewController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IComputerService _computerService;
        public ReviewController(ApplicationDbContext applicationDbContext, IComputerService computerService)
        {
            _applicationDbContext = applicationDbContext;
            _computerService = computerService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(ComputerViewModel computerViewModel, int id)
        {
            Review review = new Review
            {
                ComputerId = id,
                Text = computerViewModel.Review.Text,
                Rating = 1
            };
            _applicationDbContext.Reviews.Add(review);
            _applicationDbContext.SaveChanges();

            return RedirectToAction("Detail", "Product", new { computerId = id });
        }
    }
}
