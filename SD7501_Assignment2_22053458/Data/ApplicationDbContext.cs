using Microsoft.EntityFrameworkCore;
using SD7501_Assignment2_22053458.Models;

namespace SD7501_Assignment2_22053458.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Category { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Interior", Description = "Inside of the car" },
                new Category { Id = 2, Name = "Exterior", Description = "Outside of the car" },
                new Category { Id = 3, Name = "Lighting", Description = "Headlights and LED" },
                new Category { Id = 4, Name = "Brakes & Suspension", Description = "To stop the car" },
                new Category { Id = 5, Name = "Exhaust", Description = "Waste coming out of the car" },
                new Category { Id = 6, Name = "Engines", Description = "Make the car runs" }
                );
        }
    }
}
