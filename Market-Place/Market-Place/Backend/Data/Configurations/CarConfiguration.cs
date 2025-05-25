using Market_Place.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Market_Place.Backend.Data.Configurations;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.ToTable("Cars");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id)
            .HasMaxLength(50)
            .IsRequired();
        
        builder.Property(x => x.Price)
            .HasColumnType("decimal(18,2)");
        
        //Связи
        builder.HasMany(c => c.Images)
            .WithOne(i => i.Car)
            .HasForeignKey(i => i.CarId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}