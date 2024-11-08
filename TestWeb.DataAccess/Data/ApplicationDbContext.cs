using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestWeb.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TestWeb.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Description = "Praesent vitae sodales libero.",
                    ISBN = "SWD6545654",
                    Author = "Billy Spark",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Dark Hours",
                    Description = "The story of a man.",
                    ISBN = "SWD9533654",
                    Author = "Tony Star",
                    ListPrice = 78,
                    Price = 70,
                    Price50 = 65,
                    Price100 = 55,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "12th Fail",
                    Description = "Story of IAS Ofacer.",
                    ISBN = "SWD8833654",
                    Author = "jhon amait",
                    ListPrice = 44,
                    Price = 54,
                    Price50 = 66,
                    Price100 = 33,
                    CategoryId = 2,
                    ImageUrl = ""
                }
                );
        }
    }
}
