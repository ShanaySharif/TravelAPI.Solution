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
            new Destination { DestinationId = 1, CityName = "Washington DC", CountryName = "United States", Review = "See important national landmarks", Rating = 8}, 
            new Destination { DestinationId = 2, CityName = "London", CountryName = "United Kingdom", Review = "Lovely valleys and streams", Rating = 9},
            new Destination { DestinationId = 3, CityName = "Atlanta", CountryName = "United States", Review = "Hot and muggy!", Rating = 4},
            new Destination { DestinationId = 4, CityName = "Paris", CountryName = "France", Review = "Tres bien", Rating = 9},
            new Destination { DestinationId = 5, CityName = "New York City", CountryName = "United States", Review = "Top of the rock", Rating = 9},
            new Destination { DestinationId = 6, CityName = "Boston", CountryName = "United States", Review = "Visit the Green Monster", Rating = 8},
            new Destination { DestinationId = 7, CityName = "Cairo", CountryName = "Egypt", Review = "The pyramids are smaller in real life", Rating = 4},
            new Destination { DestinationId = 8, CityName = "Johannesburg", CountryName = "South Africa", Review = "Swim with white sharks", Rating = 8},
            new Destination { DestinationId = 9, CityName = "Tokyo", CountryName = "Japan", Review = "Extremely lively city", Rating = 7},
            new Destination { DestinationId = 10, CityName = "Milan", CountryName = "Italy", Review = "Visit the duomo", Rating = 10}
        );
    }
  }
}
