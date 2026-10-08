using System;
using System.Collections.Generic;
using System.Text;

namespace Search.Domain.CategoryAgg
{
    public class Category
    {
        public int Id { get; private set; }
        public Name Name { get; private set; } = null!;

        public List<Product> Products { get; set; } = [];


        private Category()
        {
            
        }

        public Category(Name name)
        {
            Name = name;
        }
    }

    
}
