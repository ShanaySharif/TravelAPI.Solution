using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Models
{
  public class TravelAPIContext : DbContext
  {
    public DbSet<Destination> Destinations { get; set; }

    public TravelAPIContext(DbContextOptions<TravelAPIContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Destination>()
        .HasData(
            //insert destinations data here.
          
          
        );
    }
  }
}