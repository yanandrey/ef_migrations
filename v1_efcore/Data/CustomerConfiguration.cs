using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using v1_efcore.Models;

namespace v1_efcore.Data
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                .ToTable("customer");
            
            builder
                .Property(p => p.Id)
                .HasColumnName("id");
            
            builder
                .Property(p => p.FirstName)
                .HasColumnName("first_name")
                .HasColumnType("varchar(50)")
                .IsRequired();
            
            builder
                .Property(p => p.LastName)
                .HasColumnName("last_name")
                .HasColumnType("varchar(50)")
                .IsRequired();
            
            builder
                .Property(p => p.Email)
                .HasColumnName("email")
                .HasColumnType("varchar(50)")
                .IsRequired();
            
            builder
                .Property(p => p.Birthday)
                .HasColumnName("birthday");

            builder
                .Property(p => p.Enabled)
                .HasColumnName("enabled");
            
            builder
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("now()")
                .IsRequired();
        }
    }
}