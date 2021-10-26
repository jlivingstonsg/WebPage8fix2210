using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPage8.Models
{
    public class Payment
    {
        public decimal TotalPrice { get; set; }
        public int OrderId { get; set; }
    }
}
