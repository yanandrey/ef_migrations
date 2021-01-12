using Microsoft.EntityFrameworkCore;

namespace v2_efcore.Models.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        
        public DbSet<Customer> Customers { get; set; }
    }
}