using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebPage8.Models
{
    public class ApplicationUser : IdentityUser
    {
               
        [Required]
        [StringLength(50, MinimumLength = 2)]
         public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }

        //public int RoleId { get; set; }

        //public List<Role> Roles { get; set; }
    }
}
