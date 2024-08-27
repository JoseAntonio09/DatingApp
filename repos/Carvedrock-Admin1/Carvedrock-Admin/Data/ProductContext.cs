using Carvedrock_Admin.Models;
using Microsoft.EntityFrameworkCore;

namespace Carvedrock_Admin.Data
{
    public class ProductContext: DbContext
    {

        public  ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }


    }
}
