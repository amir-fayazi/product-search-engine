

namespace Search.Domain.CategoryAgg
{
    public class Name
    {
        public string Value { get; } = null!;

        private Name() { }

        public Name(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Category name cannot be empty or whitespace.", nameof(value));

            string trimmedValue = value.Trim();

            if (trimmedValue.Length > 50)
                throw new ArgumentException("Category name cannot exceed 50 characters.", nameof(value));

            Value = trimmedValue;
        }

        public override string ToString() => Value;
        
    }
}
