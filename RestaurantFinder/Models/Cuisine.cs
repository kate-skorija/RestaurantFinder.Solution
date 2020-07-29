using System.Collections.Generic;

namespace RestaurantFinder.Models
{
  public class Cuisine
  {
    public Cuisine()
    {
      this.Restaurants = new HashSet<Restaurant>(); // HashSet is list but chaotic
    }
    public string Name { get; set; }
    public int CuisineId { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; } // virtual allows us to utilize lazy loading
  }
}