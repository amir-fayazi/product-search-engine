using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Search.Domain.CategoryAgg;

namespace Serach.Infrastructure.Configurations
{
    public class CategoryConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.OwnsOne(x => x.Name, name =>
            {
                name.Property(x => x.Value);

                name.HasData(
                    new { CategoryId = 1, Value = "Laptop" },
                    new { CategoryId = 2, Value = "Phone" },
                    new { CategoryId = 3, Value = "Mouse" },
                    new { CategoryId = 4, Value = "Headphones" }
                );
            });

            builder.HasMany(x => x.Products)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId);

            builder.HasData(
                new { Id = 1 },
                new { Id = 2 },
                new { Id = 3 },
                new { Id = 4 }
            );
        }
    }
}