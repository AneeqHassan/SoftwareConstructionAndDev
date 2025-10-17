
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

IList<Employee> employees = new List<Employee>
{
    new Employee
    {
    }
};

//Price Greater than 100
var query = products
    .Where(p => p.Price > 100)
   .Select(p => new { p.ProductName, p.Price, p.Category });

//Find all products in stock with greater than 20 items

var inStockQuery = products
    .Select(p => new
    {

        p.ProductName,
        p.Price,
        p.Category,
        inStock = p.Stock > 20 ? "Yes" : "No"

    }
    );

var orderedQuery = products
    .OrderBy(p => p.Category)
    .ThenByDescending(p => p.Price)
    .Select(p => new { p.ProductName, p.Price, p.Category });

//Count electronic products

var productcount = products
    .Count(p => p.Category == "Electronic");

Console.WriteLine($"\nTotal Electronic products: {productcount}");

var firstElement = products
    .OrderByDescending(p => p.Price)
    .First();
Console.WriteLine($"Product with highest price: {firstElement.ProductName} : Price {firstElement.Price}");

foreach(var item in inStockQuery)
{
    Console.WriteLine($"Product: {item.ProductName}, " +
        $"Price: {item.Price}, " +
        $"Category: {item.Category}, " +
        $"Stock: {item.inStock}");
}
public class Product
{
    public int ProductId {  get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Stock {  get; set; }
    public string Category { get; set; }
}



public class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
    public int YearsExperience { get; set; }
}