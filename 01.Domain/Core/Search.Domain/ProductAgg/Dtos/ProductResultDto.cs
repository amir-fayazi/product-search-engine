using System;
using System.Collections.Generic;
using System.Text;

namespace Search.Domain.ProductAgg.Dtos
{
    public class ProductResultDto
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Stock { get; set; }
        public string CategoryName { get; set; }
        public bool IsAvailable { get; set; }
    }


}
