using Microsoft.EntityFrameworkCore;
using Shopping.Models;
using Microsoft.Extensions.Options;

namespace Shopping.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 1, Name = "iPhone 9", Description = "An apple mobile ", Price =  4799F  });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 2, Name = "Samsung Universe 9", Description = "Samsung's new variant", Price = 299F });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 3, Name = "Keyboard", Description = "A device to write in", Price = 459F });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 4, Name = "Microsoft Surface Laptop 4", Description = "Capture ideas on the vibrant touchscreen.", Price = 9999F });
        }
    }
}
