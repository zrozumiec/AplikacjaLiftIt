using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LiftIt.Models;
using Microsoft.Extensions.Configuration;

namespace LiftIt.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Waga> Waga { get; set; }
        public DbSet<Cwiczenia> Cwiczenie { get; set; }
        public DbSet<Obwody> Obwody { get; set; }
        public DbSet<Seria> Seria { get; set; }
        public DbSet<Typ> Typ { get; set; }
        public DbSet<TypCwiczenie> TypCwiczenie { get; set; }
        public DbSet<Waga> Wagi { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
