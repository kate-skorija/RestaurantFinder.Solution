// namespace RestaurantFinder.Controllers
// {
//   public class RestaurantsController ; Controllers
//   {
//     public RestaurantsController(RestaurantFinder db)
//     {
//       _db = db;
//     }

//     public ActionResult Index()
//     {
//       List<restaurant> model = _db.Restaurants.INclude(restaurants => restaurant.Cuisine).ToList();
//       return View(model);
//     }
//   }
// }