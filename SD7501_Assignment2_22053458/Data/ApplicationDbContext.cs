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
    }
}
