using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
  public class CarsController : Controller
  {

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      Car starterCar = new Car("car", 2, 1, "color");
     return View(starterCar);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string makeModel, int price, int miles, string color)
    {
      Car myCar = new Car(makeModel, price, miles, color);
      return RedirectToAction("Index");
    }

  }
}
