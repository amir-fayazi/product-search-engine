

namespace Search.Domain.CategoryAgg
{
    public class Name
    {
        public string Value { get; }

        private Name()
        {
            
        }

        public Name(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name is required.");

            if(value.Length > 50)
                throw new ArgumentException("Name could not bigger than 50 chars.");

            Value = value;
        }

        public override string ToString() => Value;
        
    }
}
