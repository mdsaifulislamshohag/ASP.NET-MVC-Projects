using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabManagementSystem.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Approved { get; set; }

    }
}
