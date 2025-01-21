
using MauiHWebApp.Shared.Data.Entities;
using MauiHWebApp.Shared.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHybridWebApp.Shared.Data
{
    public class AppDbContext : DbContext
    {
        

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ApplicationTokenInfo> ApplicationTokenInfo { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //IdentitySeed
            User admin = new User()
            {
                Id = 1,
                Name = "Alfa One",
                Email = "admin@system.com",
                Phone = "0123456789",
                // Password@123
                PasswordHash = "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==",
                Role = nameof(UserRole.Admin),
            };
            //admin.PasswordHash = _passwordHasher.HashPassword(admin, "Password@123");
            modelBuilder.Entity<User>().HasData(admin);
        }

        
    }
}
