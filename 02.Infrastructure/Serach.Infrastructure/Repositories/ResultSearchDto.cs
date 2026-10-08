using System;
using System.Collections.Generic;
using System.Text;

namespace Serach.Infrastructure.Repositories
{
    public class ResultSearchDto
    {
        public string Title { get; set; } = null!;
        public string CategoryName { get; set; }= null!;
        public decimal Price { get; set; }
        public string Brand { get; set; }= null!;
        public string color { get; set; } = null!;
        public int Stock { get; set; }
    };
}
