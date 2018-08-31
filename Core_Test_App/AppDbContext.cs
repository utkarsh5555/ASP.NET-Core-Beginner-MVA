using Microsoft.EntityFrameworkCore;

namespace Core_Test_App
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}