
using Search.Domain.CategoryAgg;

namespace Search.Domain.ProductAgg
{
    public class Product 
    {
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public int Stock { get; private set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }

        private Product()
        {
            
        }

        public Product(string title, string color, string brand, int stock ,Category category)
        {
            SetStock(stock);
            Title = title;
            Color = color;
            Brand = brand;
            Category = category;
        }


        public void SetStock(int stock)
        {
            if (stock <= 0)
                throw new Exception("Stock can not be negative.");
            Stock = stock;
        }

    }
}
