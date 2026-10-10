using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Search.Domain.ProductAgg;

namespace Serach.Infrastructure.Configurations
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                // Laptops
                new { Id = 1, Title = "Asus VivoBook 15", Price = 1200m, Color = "Black", Brand = "Asus", Stock = 7, CategoryId = 1 },
                new { Id = 2, Title = "Asus Zenbook Pro 14", Price = 2000m, Color = "Silver", Brand = "Asus", Stock = 4, CategoryId = 1 },
                new { Id = 3, Title = "Lenovo ThinkPad X1", Price = 2200m, Color = "Black", Brand = "Lenovo", Stock = 3, CategoryId = 1 },
                new { Id = 4, Title = "Apple MacBook Pro 14", Price = 3500m, Color = "Silver", Brand = "Apple", Stock = 2, CategoryId = 1 },
                new { Id = 5, Title = "Dell XPS 13", Price = 2200m, Color = "Gray", Brand = "Dell", Stock = 0, CategoryId = 1 },

                // Phones
                new { Id = 6, Title = "Samsung Galaxy A55", Price = 500m, Color = "Black", Brand = "Samsung", Stock = 12, CategoryId = 2 },
                new { Id = 7, Title = "Samsung Galaxy S24", Price = 950m, Color = "Silver", Brand = "Samsung", Stock = 5, CategoryId = 2 },
                new { Id = 8, Title = "Apple iPhone 16 Pro", Price = 1500m, Color = "Black", Brand = "Apple", Stock = 4, CategoryId = 2 },
                new { Id = 9, Title = "Apple iPhone 15", Price = 1000m, Color = "Blue", Brand = "Apple", Stock = 0, CategoryId = 2 },
                new { Id = 10, Title = "Xiaomi Redmi Note 14 Pro", Price = 600m, Color = "Black", Brand = "Xiaomi", Stock = 9, CategoryId = 2 },

                // Mice
                new { Id = 11, Title = "Logitech M185", Price = 25m, Color = "Black", Brand = "Logitech", Stock = 30, CategoryId = 3 },
                new { Id = 12, Title = "Logitech MX Master 3S", Price = 120m, Color = "Gray", Brand = "Logitech", Stock = 8, CategoryId = 3 },
                new { Id = 13, Title = "Razer Viper V3 Pro", Price = 150m, Color = "Black", Brand = "Razer", Stock = 4, CategoryId = 3 },
                new { Id = 14, Title = "A4Tech OP-620", Price = 20m, Color = "White", Brand = "A4Tech", Stock = 0, CategoryId = 3 },
                new { Id = 15, Title = "Logitech G Pro X", Price = 120m, Color = "White", Brand = "Logitech", Stock = 6, CategoryId = 3 },

                // Headphones
                new { Id = 16, Title = "Sony WH-1000XM5", Price = 350m, Color = "Black", Brand = "Sony", Stock = 4, CategoryId = 4 },
                new { Id = 17, Title = "Sony WH-CH720N", Price = 120m, Color = "Blue", Brand = "Sony", Stock = 10, CategoryId = 4 },
                new { Id = 18, Title = "Apple AirPods Pro 2", Price = 280m, Color = "White", Brand = "Apple", Stock = 5, CategoryId = 4 },
                new { Id = 19, Title = "Samsung Galaxy Buds3 Pro", Price = 250m, Color = "Silver", Brand = "Samsung", Stock = 2, CategoryId = 4 },
                new { Id = 20, Title = "JBL Tune 770NC", Price = 110m, Color = "Black", Brand = "JBL", Stock = 0, CategoryId = 4 }
            );
        }
    }
}