using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //protected ApplicationDbContext()
        //{
        //}

        public DbSet<Category> Categories { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Category>().HasData(
        //        new Category { Id = 5, DisplayOrder = 2500, Name = "Foods" },
        //        new Category { Id = 5, DisplayOrder = 2500, Name = "Foods" },
        //        new Category { Id = 5, DisplayOrder = 2500, Name = "Foods" },
        //        new Category { Id = 5, DisplayOrder = 2500, Name = "Foods" }
        //        );
        //}
    }
}
