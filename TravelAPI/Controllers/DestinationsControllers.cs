using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelAPI.Models;

namespace TravelAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DestinationsController : ControllerBase
  {
    private readonly TravelAPIContext _db;

    public DestinationsController(TravelAPIContext db)
    {
      _db = db;
    }
    // GET api/destinations
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Destination>>> Get (int destinationId, string cityName, string countryName, string review, int rating )
    {
      IQueryable<Destination> query = _db.Destinations.AsQueryable();
      
      if (cityName != null)
      {
        query = query.Where(entry => entry.CityName == cityName);
      }
       if (countryName != null)
      {
        query = query.Where(entry => entry.CountryName == countryName);
      }
      if (rating > 0)
      {
        query = query.Where(entry => entry.Rating == rating);
      }
      var destinations = await query.ToListAsync();

      if (destinations.Count == 0)
      {
        return NotFound();
      }
      return Ok(destinations);
    }
    public IActionResult Get()
    {
      List<Destination> destinations = _db.Destinations.ToList();
      return Ok(destinations);
    }
 
    // GET: api/Destinations/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Destination>> GetDestination(int id)
    {
      Destination destination = await _db.Destinations.FindAsync(id);

      if (destination == null)
      {
        return NotFound();
      }

      return destination;
    }

    // POST api/destinations
    [HttpPost]
    public async Task<ActionResult<Destination>> Post([FromBody] Destination destination)
    {
      _db.Destinations.Add(destination);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetDestination), new { id = destination.DestinationId }, destination);
    }
 // PUT: api/Destinations/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Destination destination)
    {
      if (id != destination.DestinationId)
      {
        return BadRequest();
      }

      _db.Destinations.Update(destination);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!DestinationExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool DestinationExists(int id)
    {
      return _db.Destinations.Any(e => e.DestinationId == id);
    }

    // DELETE: api/Destinations/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDestination(int id)
    {
      Destination destination = await _db.Destinations.FindAsync(id);
      if (destination == null)
      {
        return NotFound();
      }

      _db.Destinations.Remove(destination);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}