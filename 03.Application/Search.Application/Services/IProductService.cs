using Search.Domain.ProductAgg.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Search.Application.Services
{
    public interface IProductService
    {
        ICollection<ProductResultDto> GetProductList(ProductSearchFilter filters);
    }
}
