using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantFinder.Models;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantFinder.Controllers
{
  public class CuisinesController : Controller
  {
    private readonly RestaurantFinderContext _db; // field; type is RestaurantFinderContext

    public CuisinesController(RestaurantFinderContext db) // constructor; set db property to RestaurantFinder context
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Cuisine> model = _db.Cuisines.ToList(); // references db cuisines table & creates a list, saved to model
      return View(model);
    }

  }
}