using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabManagementSystem.Models
{
    public class LabDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public LabDbContext(DbContextOptions<LabDbContext> options) : base(options)
        {
        }

        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Lab> Labs { get; set; }
        public DbSet<LabEquipmentRelation> LabEquipmentRelations { get; set; }
        public DbSet<BookEquipment> BookEquipments { get; set; }

    }
}
