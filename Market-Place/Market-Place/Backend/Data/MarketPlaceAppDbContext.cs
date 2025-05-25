using System.Reflection;
using Market_Place.Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Market_Place.Backend.Data;

public class MarketPlaceAppDbContext : DbContext
{
    public MarketPlaceAppDbContext(DbContextOptions<MarketPlaceAppDbContext> options) : base(options) { }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<CarImage> CarImages { get; set; }
    public DbSet<Advertisement> Advertisements { get; set; }
    public DbSet<Favorite> Favorites { get; set; }
    public DbSet<Review> Reviews { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    
}