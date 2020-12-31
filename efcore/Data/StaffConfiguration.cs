using System;
using efcore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace efcore.Data
{
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder
                .ToTable("staff");
            
            builder
                .Property(s => s.Id)
                .HasColumnName("id");

            builder
                .Property(s => s.FirstName)
                .HasColumnName("first_name")
                .HasColumnType("varchar(50)")
                .IsRequired();
            
            builder
                .Property(s => s.LastName)
                .HasColumnName("last_name")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(s => s.Email)
                .HasColumnName("email")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(s => s.Password)
                .HasColumnName("password")
                .HasColumnType("varchar(16)")
                .IsRequired();
            
            builder
                .Property(s => s.Birthday)
                .HasColumnName("birthday");

            builder
                .Property(s => s.Enabled)
                .HasColumnName("enabled");
            
            builder
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("now()")
                .IsRequired();
        }
    }
}