using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using v1_efcore.Models;

namespace v1_efcore.Data
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder
                .ToTable("vehicle");

            builder
                .Property(v => v.Id)
                .HasColumnName("id");

            builder
                .Property(v => v.Model)
                .HasColumnName("model")
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder
                .Property(v => v.Year)
                .HasColumnName("year");

            builder
                .Property(v => v.Plate)
                .HasColumnName("plate")
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder
                .Property(v => v.Color)
                .HasColumnName("color")
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder
                .Property(v => v.Enabled)
                .HasColumnName("enabled");
            
            builder
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("now()")
                .IsRequired();
        }
    }
}