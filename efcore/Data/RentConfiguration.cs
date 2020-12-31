using System;
using efcore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace efcore.Data
{
    public class RentConfiguration : IEntityTypeConfiguration<Rent>
    {
        public void Configure(EntityTypeBuilder<Rent> builder)
        {
            builder
                .ToTable("rent");

            builder
                .Property(r => r.Id)
                .HasColumnName("id");

            builder
                .Property(r => r.Duration)
                .HasColumnName("duration")
                .HasColumnType("int");

            builder
                .Property<DateTime>("car_exit")
                .HasColumnType("datetime")
                .HasDefaultValueSql("now()")
                .IsRequired();

            builder
                .Property(r => r.CarReturn)
                .HasColumnName("car_return")
                .HasColumnType("datetime");
        }
    }
}