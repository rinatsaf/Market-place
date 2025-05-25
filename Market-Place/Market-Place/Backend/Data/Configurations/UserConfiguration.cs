using Market_Place.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Market_Place.Backend.Data.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("User");
        // Primary key
        builder.HasKey(x => x.Id);
        
        builder.HasIndex(u => u.Email)
            .IsUnique();
        
        builder.Property(u => u.Email)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(u => u.Username)
            .HasMaxLength(50);
        
        // связи
        builder.HasMany(u => u.Cars)
            .WithOne(c => c.Seller)
            .HasForeignKey(c => c.SellerId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(u => u.Favorites)
            .WithOne(f => f.User)
            .HasForeignKey(f => f.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasMany(u => u.ReviewsReceived)
            .WithOne(r => r.User)
            .HasForeignKey(r => r.User)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasMany(u => u.ReviewsWritten)
            .WithOne(r => r.User)
            .HasForeignKey(r => r.User)
            .OnDelete(DeleteBehavior.Cascade);
    }
}