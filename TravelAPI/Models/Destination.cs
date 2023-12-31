using System.ComponentModel.DataAnnotations;

namespace TravelAPI.Models
{
  public class Destination
  {
    public int DestinationId { get; set; }

    public string CityName { get; set; }
    public string CountryName { get; set; }
    public string Review { get; set; }
    public int Rating { get; set; }
  }
}