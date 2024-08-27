using Carvedrock.Admin.Models;
using Microsoft.EntityFrameworkCore;


namespace Carvedrock.Admin.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(b => b.Price)
                .HasPrecision(18, 2);
        }
    }
}
