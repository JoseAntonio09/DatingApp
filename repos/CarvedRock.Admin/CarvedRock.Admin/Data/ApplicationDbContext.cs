using Microsoft.EntityFrameworkCore;
namespace CarvedRock.Admin.Data
{
    public class ApplicationDbContext : DbContext
    {
        //protected readonly IConfiguration Configuration;

        //public ApplicationDbContext(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    // connect to sql server with connection string from app settings
        //    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        //}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
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
