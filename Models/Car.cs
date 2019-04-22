using System;

namespace Dealership {

  class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;
    private string Color;

    public Car(string makeModel, int price, int miles, string color)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Color = color;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public string GetColor()
    {
      return Color;
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
