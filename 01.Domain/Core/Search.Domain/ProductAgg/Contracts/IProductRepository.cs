using Search.Domain.ProductAgg.Enums;
using System.Text.RegularExpressions;

namespace Search.Domain.ProductAgg.Contracts
{
    public interface IProductRepository
    {
        ICollection<Product> SearchProducts(ProductSearchFilter filters, ProductSortField productSortField, SortDirectionEnum sortDirection);
    }
}
