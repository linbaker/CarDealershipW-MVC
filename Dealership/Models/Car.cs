using System.Collections.Generic;
using System;

namespace Dealership.Models
{

  public class Car
  {
    public string MakeModel {get; set;}
    public int Price {get; set;}
    public int Miles {get; set;}
    public string Color {get; set;}
    private static List<Car> _instances = new List<Car> {};

    public Car(string makeModel, int price, int miles, string color)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Color = color;
      _instances.Add(this);
    }
    public static List<Car> GetAll()
    {
      return _instances;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }
    public bool WorthMiles(int maxMiles)
    {
      return (Miles <= maxMiles);
    }
  }

}
