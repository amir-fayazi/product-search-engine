

using Microsoft.EntityFrameworkCore;
using Search.Domain.ProductAgg;
using Search.Domain.ProductAgg.Contracts;
using Search.Domain.ProductAgg.Enums;
using Serach.Infrastructure.Persistence;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Serach.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }


        public void SearchProducts(ProductSearchFilter filters, ProductSortField productSortField, SortDirectionEnum sortDirection)
        {
            IQueryable<Product> query = _context.Products.AsNoTracking();


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

            query = SortDirection(query, productSortField, sortDirection);


             GetResultSearch(query);
                        
        }

        public IQueryable<Product> SortDirection(IQueryable<Product> query, ProductSortField productSortField, SortDirectionEnum sortDirection)
        {
            if (sortDirection == SortDirectionEnum.Ascending)
            {
                switch (productSortField)
                {
                    case ProductSortField.Title:
                        query = query.OrderBy(x => x.Title);
                        break;
                    case ProductSortField.Price:
                        query = query.OrderBy(x => x.Price);

                        break;
                    case ProductSortField.Stock:
                        query = query.OrderBy(x => x.Stock);
                        break;
                    default:
                        break;
                }
            }
            else if (sortDirection == SortDirectionEnum.Descending)
            {
                switch (productSortField)
                {
                    case ProductSortField.Title:
                        query = query.OrderByDescending(x => x.Title);
                        break;
                    case ProductSortField.Price:
                        query = query.OrderByDescending(x => x.Price);
                        break;
                    case ProductSortField.Stock:
                        query = query.OrderByDescending(x => x.Stock);
                        break;
                    default:
                        break;
                }
            }

            return query;

        }

        public List<ResultSearchDto> GetResultSearch(IQueryable<Product> query)
        {
            var pageNumber = 0;
            var pageSize = 5;

            return query.Select(x => new ResultSearchDto
            {
                Title = x.Title,
                CategoryName = x.Category.Name.Value,
                Price = x.Price,
                Brand = x.Brand,
                color = x.Color,
                Stock = x.Stock
            })
              .Skip((pageNumber - 1) * pageSize)
              .Take(pageSize)
              .ToList();
               
        } 
        
    }
   
}
