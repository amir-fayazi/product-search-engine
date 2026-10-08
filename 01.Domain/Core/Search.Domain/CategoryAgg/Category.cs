using Search.Domain.ProductAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace Search.Domain.CategoryAgg
{
    public class Category
    {
        public int Id { get; private set; }
        public Name Name { get;  set; } = null!;

        public ICollection<Product> Products { get; private set; } = [];


        private Category() { }

        public Category(Name name)
        {
            SetName(name);
        }

        public void SetName(Name name)
        {
            ArgumentNullException.ThrowIfNull(name);
            Name = name;
        }
    }

    
}
