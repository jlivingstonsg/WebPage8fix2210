using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage8.Models;

namespace WebPage8.ViewModels
{
    public class ComputerViewModel
    {
        public List<Computer> Computers { get; set; }
        public Computer Computer { get; set; }
        public Review Review { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public List<Category> Categories { get; set; }
        public string Search { get; set; }
        public int CategoryIdToFilter { get; set; }

    }
}
