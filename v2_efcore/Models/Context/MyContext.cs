using Microsoft.EntityFrameworkCore;

namespace v2_efcore.Models.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Hiring> Hirings { get; set; }
    }
}