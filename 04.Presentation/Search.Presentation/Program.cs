using ADO.NetDemoConsoleApp;
using Search.Application.Services;
using Search.Domain.CategoryAgg;
using Search.Domain.ProductAgg;
using Search.Domain.ProductAgg.Contracts;
using Search.Domain.ProductAgg.Dtos;
using Search.Domain.ProductAgg.Enums;
using Search.Presentation.Helpers;
using Serach.Infrastructure.Persistence;
using Serach.Infrastructure.Repositories;

var contex = new AppDbContext();
IProductRepository productRepo = new ProductRepository(contex);
IProductService productService = new ProductService(productRepo);




Console.WriteLine("========== PRODUCT SEARCH ==========");
Console.WriteLine("Press Enter to skip optional filters.\n");

var filters = new ProductSearchFilter
{
    Title = ConsoleInputReader.ReadString("Product Title: "),

    CategoryName = ConsoleInputReader.ReadString("Category Name: "),

    MinPrice = ConsoleInputReader.ReadDecimal("Minimum Price: "),
    MaxPrice = ConsoleInputReader.ReadDecimal("Maximum Price: "),

    MinStock = ConsoleInputReader.ReadInt("Minimum Stock: "),

    Brands = ConsoleInputReader.ReadStringList("Brands (comma-separated): "),
    Colors = ConsoleInputReader.ReadStringList("Colors (comma-separated): "),

    SortBy = ConsoleInputReader.ReadSortField(),
    SortDirection = ConsoleInputReader.ReadSortDirection(),

    PageNumber = ConsoleInputReader.ReadInt("Page Number (default 1): ") ?? 1,
    PageSize = ConsoleInputReader.ReadInt("Page Size (default 10): ") ?? 10
};


try
{
    var prouctResult = productService.GetProductList(filters);
    ConsolePainter.WriteTable(prouctResult, ConsoleColor.White, ConsoleColor.White);

}
catch (Exception ex)
{
    Console.WriteLine(ex);
    Console.ReadKey();
}


Console.ReadKey();







