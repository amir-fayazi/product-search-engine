using Search.Domain.ProductAgg.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Search.Domain.ProductAgg.Dtos
{
    public class ProductSearchFilter
    {
        public string? Title { get; set; }
        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; }

        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        public ICollection<string>? Brands { get; set; }
        public ICollection<string>? Colors { get; set; }
        public int? MinStock { get; set; }

        
        public SortField SortBy { get; set; } = SortField.Title;
        public SortDirectionEnum SortDirection { get; set; } = SortDirectionEnum.Ascending;

        //public ProductSortField? ThenSortBy { get; set; }
        //public SortDirectionEnum ThenSortDirection { get; set; } = SortDirectionEnum.Ascending;

        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
