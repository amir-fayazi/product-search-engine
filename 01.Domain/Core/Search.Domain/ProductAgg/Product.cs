
using Search.Domain.CategoryAgg;

namespace Search.Domain.ProductAgg
{
    public class Product 
    {
        public int Id { get; private set; }
        public string Title { get; private set; } = null!;
        public decimal Price { get; private set; }
        public string Color { get; private set; } = null!;
        public string Brand { get; private set; } = null!;
        public int Stock { get; private set; }

        public int CategoryId { get; private set; }
        public Category Category { get; private set; } = null!;

        private Product(){}
        
        

        public Product(string title, decimal price, string color, string brand, int stock, Category category)
        {
            SetTitle(title);
            SetPrice(price);
            SetColor(color);
            SetBrand(brand);
            SetStock(stock);
            SetCategory(category);
        }


        public void SetTitle(string title)
        {
            Title = ValidateText(title, nameof(title), 100);
        }

        public void SetColor(string color)
        {
            Color = ValidateText(color, nameof(color), 30);
        }

        public void SetBrand(string brand)
        {
            Brand = ValidateText(brand, nameof(brand), 50);
        }

        public void SetPrice(decimal price)
        {
            if (price < 0)
                throw new ArgumentOutOfRangeException(nameof(price), "Price cannot be negative.");

            Price = price;
        }

        public void SetStock(int stock)
        {
            if (stock < 0)
                throw new ArgumentOutOfRangeException(nameof(stock), "Stock cannot be negative.");

            Stock = stock;
        }

        public void SetCategory(Category category)
        {
            ArgumentNullException.ThrowIfNull(category);
            Category = category;
        }


        private static string ValidateText(string value, string parameterName, int maxLength)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"{parameterName} cannot be empty or whitespace.");

            string trimmedValue = value.Trim();

            if (trimmedValue.Length > maxLength)
                throw new ArgumentException($"{parameterName} cannot exceed {maxLength} characters.");

            return trimmedValue;
        }
    }
}
