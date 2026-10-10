

using Search.Domain.ProductAgg.Contracts;
using Search.Domain.ProductAgg.Dtos;

namespace Search.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepo;
        public ProductService(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }
        public ICollection<ProductResultDto> GetProductList(ProductSearchFilter filters)
        {
            ArgumentNullException.ThrowIfNull(filters);

            if (filters.MinPrice.HasValue &&
                filters.MaxPrice.HasValue &&
                filters.MinPrice > filters.MaxPrice)
            {
                throw new ArgumentException(
                    "Minimum price cannot be greater than maximum price.");
            }

            return _productRepo.SearchProducts(filters);
        }
    }
}
