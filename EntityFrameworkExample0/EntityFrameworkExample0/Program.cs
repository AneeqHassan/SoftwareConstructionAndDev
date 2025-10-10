// See https://aka.ms/new-console-template for more information
using EntityFrameworkExample0.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddDbContext<DatabaseContext>(options =>
            options.UseSqlServer("Data Source=(local);Initial Catalog=TechNova-Ecommerce;Integrated Security=True;Encrypt=False"));
    })
    .Build();


//Data Source=(local);Initial Catalog=TechNova-Ecommerce;Integrated Security=True;Encrypt=False


