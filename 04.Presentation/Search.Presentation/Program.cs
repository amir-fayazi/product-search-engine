using ADO.NetDemoConsoleApp;
using Search.Application.Services;
using Search.Domain.CategoryAgg;
using Search.Domain.ProductAgg;
using Search.Domain.ProductAgg.Contracts;
using Search.Domain.ProductAgg.Dtos;
using Search.Domain.ProductAgg.Enums;
using Serach.Infrastructure.Persistence;
using Serach.Infrastructure.Repositories;

var contex = new AppDbContext();
IProductRepository productRepo = new ProductRepository(contex); 
IProductService productService = new ProductService(productRepo); 



Console.WriteLine("Title: ");
var title = Console.ReadLine();


Console.WriteLine("CategoryName: ");
var category = Console.ReadLine();


Console.WriteLine("MinStock: ");
var minStock = int.Parse(Console.ReadLine());


Console.WriteLine("Price: ");
var minPrice = decimal.Parse(Console.ReadLine()!);

Console.WriteLine("Page Size: ");
var pageSize = int.Parse(Console.ReadLine()!);


Console.WriteLine("page Number: ");
var pageNumber = int.Parse(Console.ReadLine()!);



var filters = new ProductSearchFilter()
{
    Title = title,
    CategoryName = category,
    MinStock = minStock,
    MinPrice = minPrice,

    PageSize = pageSize,
    PageNumber = pageNumber,
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




