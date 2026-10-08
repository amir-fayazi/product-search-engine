using System;
using System.Collections.Generic;
using System.Text;

namespace Search.Domain.ProductAgg.Contracts
{
    public class ProductSearchFilter
    {
        public string? Title { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public string? CategoryName { get; set; }
        public ICollection<string>? Colors { get; set; }
        public ICollection<string>? Brands { get; set; }
        public int? MinStock { get; set; }
    }
}
