using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using v1_efcore.Models;

namespace v1_efcore.Data
{
    public class HiringConfiguration : IEntityTypeConfiguration<Hiring>
    {
        public void Configure(EntityTypeBuilder<Hiring> builder)
        {
            builder
                .ToTable("hiring");

            builder
                .Property(h => h.Id)
                .HasColumnName("id");

            builder
                .Property(h => h.Beginning)
                .HasColumnName("beginning")
                .HasColumnType("datetime");

            builder
                .Property(h => h.Department)
                .HasColumnName("department")
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder
                .Property(h => h.Function)
                .HasColumnName("function")
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder
                .Property(h => h.Salary)
                .HasColumnName("salary");

            builder
                .Property(h => h.Enabled)
                .HasColumnName("enabled");
        }
    }
}