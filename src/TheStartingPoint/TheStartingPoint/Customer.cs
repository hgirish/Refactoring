using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheStartingPoint
{
  public class Customer
  {
    public string Name { get; set; }
    private readonly IList<Rental> _rentals = new List<Rental>();
    public Customer(string name)
    {
      Name = name;
    }
    public void AddRental(Rental rental)
    {
      _rentals.Add(rental);
    }

    public string Statement()
    {

      string result = "Rental Record for " + Name + "\n";
      foreach (var each in _rentals)
      {
        result += "\t" + each.Movie.Title + "\t" + each.GetCharge() + "\n";
      }
      //add footer lines
      result += "Amount owed is " + GetTotalCharge() + "\n";
      result += "You earned " + GetTotalFrequentRenterPoints() + " frequent renter points";
      return result;

    }
    public string HtmlStatement()
    {
    var sb = new StringBuilder();
    sb.AppendFormat("<h1>Rentals for <em>{0}</em></h1>", Name);

      foreach (var rental in _rentals)
      {
        sb.AppendFormat("{0} : {1:c}<br />", rental.Movie, rental.GetCharge());
      }
      sb.AppendFormat("<p>You ovw <em>{0:c}</em></p>", GetTotalCharge());
      sb.AppendFormat("On this rental you earned <em>{0}</em> frequent renter points", 
      GetTotalFrequentRenterPoints());
      return sb.ToString();
    }
    private int GetTotalFrequentRenterPoints()
    {
      return _rentals.Sum(rental => rental.FrequentRenterPoints);
    }

    public double GetTotalCharge()
    {
      return _rentals.Sum(rental => rental.GetCharge());
    }

  }
}