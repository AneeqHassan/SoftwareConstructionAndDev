using Framework_and_LINQ.Models;
using Framework_and_LINQ.Models.Entities ;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddDbContext<DatabaseContext>(options =>
            options.UseSqlServer("Data Source=(local);Initial Catalog=LINQ;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"));
    })
    .Build();

// Get the database context
using var scope = host.Services.CreateScope();
var dbContext = scope.ServiceProvider.GetRequiredService<DatabaseContext>();

    // Ensure the database is created
    await dbContext.Database.EnsureCreatedAsync();
    Console.WriteLine("✅ Database created successfully!\n");

    // Seed Data
    if (!dbContext.Students.Any())
    {
        var s1 = new Student { Name = "Ali", Age = 20 };
        var s2 = new Student { Name = "Sara", Age = 22 };
        var s3 = new Student { Name = "Ahmed", Age = 19 };

        var c1 = new Course { Title = "Programming", Credits = 3 };

        dbContext.AddRange(s1, s2, s3, c1);
        await dbContext.SaveChangesAsync();

 
    }

       
