using EntityFrameworkExample0.Model.Entities;
using Microsoft.EntityFrameworkCore;


namespace EntityFrameworkExample0.Model
{

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}