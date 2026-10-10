
using Search.Domain.ProductAgg.Enums;

namespace Search.Presentation.Helpers;

public static class ConsoleInputReader
{
    // String
    public static string? ReadString(string message)
    {
        Console.Write(message);
        string? input = Console.ReadLine();

        return string.IsNullOrWhiteSpace(input)
            ? null
            : input.Trim();
    }

    // Integer
    public static int? ReadInt(string message)
    {
        while (true)
        {
            Console.Write(message);
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                return null;

            if (int.TryParse(input, out int value))
                return value;

            Console.WriteLine("Invalid integer. Try again.");
        }
    }

    // Decimal
    public static decimal? ReadDecimal(string message)
    {
        while (true)
        {
            Console.Write(message);
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                return null;

            if (decimal.TryParse(input, out decimal value))
                return value;

            Console.WriteLine("Invalid decimal. Try again.");
        }
    }

    // Sort Field Enum
    public static SortField ReadSortField()
    {
        while (true)
        {
            Console.WriteLine("\nSort By:");
            Console.WriteLine("1. Title");
            Console.WriteLine("2. Price");
            Console.WriteLine("3. Stock");
            Console.Write("Choose (Enter for Title): ");

            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                return SortField.Title;

            if (Enum.TryParse<SortField>(input, out var value)
                && Enum.IsDefined(value))
            {
                return value;
            }

            Console.WriteLine("Invalid sort option. Try again.");
        }
    }

    // Sort Direction Enum
    public static SortDirectionEnum ReadSortDirection()
    {
        while (true)
        {
            Console.WriteLine("\nSort Direction:");
            Console.WriteLine("1. Ascending");
            Console.WriteLine("2. Descending");
            Console.Write("Choose (Enter for Ascending): ");

            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                return SortDirectionEnum.Ascending;

            if (Enum.TryParse<SortDirectionEnum>(input, out var value)
                && Enum.IsDefined(value))
            {
                return value;
            }

            Console.WriteLine("Invalid direction. Try again.");
        }
    }

    // String Collection
    public static ICollection<string>? ReadStringList(string message)
    {
        while (true)
        {
            Console.Write(message);
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                return null;

            var items = input
                .Split(',', StringSplitOptions.RemoveEmptyEntries
                           | StringSplitOptions.TrimEntries)
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();

            if (items.Count > 0)
                return items;

            Console.WriteLine("Invalid list. Try again.");
        }
    }
}
