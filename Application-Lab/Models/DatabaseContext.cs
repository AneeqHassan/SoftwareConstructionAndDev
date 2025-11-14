using Microsoft.EntityFrameworkCore;

namespace Application_Lab.Models.Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
