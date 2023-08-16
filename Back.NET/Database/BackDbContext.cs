using Microsoft.EntityFrameworkCore;
using Back.NET.Database.Models;

namespace Back.NET.Database;

public class BackDbContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Server=localhost;Port=5432;Database=Pustok;User Id=postgres;Password=postgresql";

        optionsBuilder.UseNpgsql(connectionString);

        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<SlideBanner> SlideBanners { get; set; }


}
