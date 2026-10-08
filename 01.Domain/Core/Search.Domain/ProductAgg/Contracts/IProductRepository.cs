using Search.Domain.ProductAgg.Dtos;
using Search.Domain.ProductAgg.Enums;
using System.Text.RegularExpressions;

namespace Search.Domain.ProductAgg.Contracts
{
    public interface IProductRepository
    {
        ICollection<ProductResultDto> SearchProducts(ProductSearchFilter filters);
    }
}
