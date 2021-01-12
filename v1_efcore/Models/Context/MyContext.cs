using Microsoft.EntityFrameworkCore;
using v1_efcore.Data;

namespace v1_efcore.Models.Context
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleConfiguration());
            modelBuilder.ApplyConfiguration(new StaffConfiguration());
            modelBuilder.ApplyConfiguration(new RentConfiguration());
            modelBuilder.ApplyConfiguration(new AdressConfiguration());
            modelBuilder.ApplyConfiguration(new HiringConfiguration());
        }
    }
}