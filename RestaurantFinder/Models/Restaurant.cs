namespace RestaurantFinder.Models;
{
  public class Restaurant
  {
    public string Name { get; set; }
    public int Rating { get; set; }
    public int RestaurantId { get; set; }
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; } // double Cuisine because the first Cuisine references the Cuisine class we've already made in the Cuisine model; 
  }
}

