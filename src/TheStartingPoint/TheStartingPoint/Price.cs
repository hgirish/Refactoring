namespace TheStartingPoint
{
  public abstract class Price
  {
    public abstract int GetPriceCode();
    public abstract double GetCharge(int daysRented);

    public virtual int GetFrequentRenterPoints(int daysRented)
    {
      return 1;
    }
  }

  class RegularPrice : Price
  {
    public override int GetPriceCode()
    {
      return Movie.Regular;
    }
    public override double GetCharge(int daysRented)
    {
      double result = 2;

      if (daysRented <= 2) return result;
      result += (daysRented - 2) * 1.5;

      return result;
    }
  }

  class NewReleasePrice : Price
  {
    public override int GetPriceCode()
    {
      return Movie.NewRelease;
    }
    public override double GetCharge(int daysRented)
    {
      return  daysRented * 3;
    }
    public override int GetFrequentRenterPoints(int daysRented)
    {
      return  daysRented > 1 ? 2 : 1;
    }
    
  }

  class ChildrensPrice : Price
  {
    public override int GetPriceCode()
    {
      return Movie.Childrens;
    }
    public override double GetCharge(int daysRented)
    {
      var result = 1.5;
      if (daysRented > 3)
        result += (daysRented - 3) * 1.5;
      return result;

    }
  }
}