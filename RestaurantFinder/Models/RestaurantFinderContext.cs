using Microsoft.EntityFrameworkCore;

namespace RestaurantFinder.Models
{
  public class RestaurantFinderContext : DbContext // DbContext is how we reference a db in an app
  {
    public virtual DbSet<Cuisine> Cuisines { get; set; } // lazy load so that you don't have to load all the restaurants under 1 cuisine. Tables in the db are represented by DbSet
    public DbSet<Restaurant> Restaurants { get; set; } // eager load bc 1 restaurant only has 1 cuisine

    public RestaurantFinderContext(DbContextOptions options) : base(options) { } //constructor inherits Startup.cs options to restaurant finder context (db)
  }
}