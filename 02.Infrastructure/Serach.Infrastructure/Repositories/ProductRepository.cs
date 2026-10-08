

using Microsoft.EntityFrameworkCore;
using Search.Domain.ProductAgg;
using Search.Domain.ProductAgg.Contracts;
using Search.Domain.ProductAgg.Dtos;
using Search.Domain.ProductAgg.Enums;
using Serach.Infrastructure.Persistence;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Serach.Infrastructure.Repositories
{
    public class ProductRepository 
    {
        private readonly AppDbContext _context;
        
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public ICollection<ProductResultDto> SearchProducts(ProductSearchFilter filters)
        {
            IQueryable<Product> query = _context.Products.AsNoTracking();

            query = ApplyFiltering(query, filters);

            query = ApplySorting(query, filters.SortBy, filters.SortDirection);

            return [.. query.Select(x => new ProductResultDto
            {
                Title = x.Title,
                CategoryName = x.Category.Name.Value,
                Brand = x.Brand,
                Color = x.Color,
                Price = x.Price,
                Stock = x.Stock,
                IsAvailable = x.Stock > 0
            })];
        }

        private static IQueryable<Product> ApplySorting(
            IQueryable<Product> query,
            ProductSortField field,
            SortDirectionEnum direction)
        {
            bool descending = direction == SortDirectionEnum.Descending;

            return field switch
            {
                ProductSortField.Title => descending
                    ? query.OrderByDescending(x => x.Title)
                    : query.OrderBy(x => x.Title),

                ProductSortField.Price => descending
                    ? query.OrderByDescending(x => x.Price)
                    : query.OrderBy(x => x.Price),

                ProductSortField.Stock => descending
                    ? query.OrderByDescending(x => x.Stock)
                    : query.OrderBy(x => x.Stock),

                _ => throw new ArgumentOutOfRangeException(nameof(field))
            };
        }

        private static IQueryable<Product> ApplyFiltering(IQueryable<Product> query, ProductSearchFilter filters)
        {
            if (!string.IsNullOrWhiteSpace(filters.CategoryName))
                query = query.Where(x => x.Category.Name.Value == filters.CategoryName);

            if (!string.IsNullOrWhiteSpace(filters.Title))
                query = query.Where(x => x.Title.Contains(filters.Title));

            if (filters.Brands is { Count: > 0 })
                query = query.Where(x => filters.Brands.Contains(x.Brand));

            if (filters.Colors is { Count: > 0 })
                query = query.Where(x => filters.Colors.Contains(x.Color));

            if (filters.MinPrice.HasValue)
                query = query.Where(x => x.Price >= filters.MinPrice.Value);

            if (filters.MaxPrice.HasValue)
                query = query.Where(x => x.Price <= filters.MaxPrice.Value);

            if (filters.MinStock.HasValue)
                query = query.Where(x => x.Stock >= filters.MinStock.Value);

            return query;
        }


    }

}
