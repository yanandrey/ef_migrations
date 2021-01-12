using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using v1_efcore.Models;

namespace v1_efcore.Data
{
    public class AdressConfiguration : IEntityTypeConfiguration<Adress>
    {
        public void Configure(EntityTypeBuilder<Adress> builder)
        {
            builder
                .ToTable("adress");

            builder
                .Property(a => a.Id)
                .HasColumnName("id");

            builder
                .Property(a => a.StreetName)
                .HasColumnName("street_name")
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder
                .Property(a => a.HouseNumber)
                .HasColumnName("house_number");
            
            builder
                .Property(a => a.ZipCode)
                .HasColumnName("zip_code");
            
            builder
                .Property(a => a.City)
                .HasColumnName("city")
                .HasColumnType("varchar(25)")
                .IsRequired();
            
            builder
                .Property(a => a.Country)
                .HasColumnName("country")
                .HasColumnType("varchar(25)")
                .IsRequired();
        }
    }
}