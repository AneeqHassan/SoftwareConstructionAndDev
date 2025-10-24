using lecture5Lab.Models.Entities;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using lecture5Lab.Models;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddDbContext<DatabaseContext>(options =>
            options.UseSqlServer("Data Source=(local);Initial Catalog=company;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"));
    })
    .Build();

IList<Product> products = new List<Product>
{
    new Product { ProductId = 1,
        ProductName = "Laptop",
        Price = 999.99m,
        Stock = 10,
        Category = "Electronics" },
    new Product { ProductId = 2,
        ProductName = "Smartphone",
        Price = 699.99m,
        Stock = 25,
        Category = "Electronics" },
    new Product { ProductId = 3,
        ProductName = "Desk Chair",
        Price = 89.99m,
        Stock = 15,
        Category = "Furniture" },
    new Product { ProductId = 4,
        ProductName = "Bookcase",
        Price = 129.99m, Stock = 5,
        Category = "Furniture" },
    new Product { ProductId = 5,
        ProductName = "Headphones",
        Price = 199.99m, Stock = 30,
        Category = "Electronics" }
};