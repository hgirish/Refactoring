using System;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace TheStartingPoint
{
  public class Movie
  {
    public  const int Childrens = 2;
    public const int Regular = 0;
    public const int NewRelease = 1;

    private Price _price;
    public Movie(string title, int priceCode)
    {
      Title = title;
      PriceCode = priceCode;
    }

    private int _priceCode;
    public int PriceCode
    {
      get { return _priceCode; }
      set
      {
        switch (value)
        {
            case Regular:
            _price = new RegularPrice();
            break;
            case Childrens:
            _price = new ChildrensPrice();
            break;
            case NewRelease:
            _price = new NewReleasePrice();
            break;
            default:
            throw new  InvalidEnumArgumentException("PriceCode");
        }
        _priceCode = value;
      }
    }

    public string Title { get; set; }

    public double GetCharge(int daysRented)
    {
      return _price.GetCharge(daysRented);
    }

  public  int GetFrequentRenterPoints(int daysRented)
  {
    return _price.GetFrequentRenterPoints(daysRented);
    //return (PriceCode == NewRelease) && daysRented > 1 ? 2 : 1;
  }
  }
}
