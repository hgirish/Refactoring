namespace TheStartingPoint
{
  public class Rental
  {
    public Movie Movie { get; set; }
    public int DaysRented { get; set; }

    public Rental(Movie movie, int daysRented)
    {
      Movie = movie;
      DaysRented = daysRented;
    }

    public double GetCharge()
    {
      return Movie.GetCharge(DaysRented);
    }

    public int FrequentRenterPoints
    {
      get { return Movie.GetFrequentRenterPoints(DaysRented); }
    }
  }
}