using Fruittables.Models;
using Microsoft.EntityFrameworkCore;

namespace Fruittables.DAL
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

      
        public DbSet<Product> Slides { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }


    }
}
