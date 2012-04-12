using NUnit.Framework;

namespace TheStartingPoint.Tests
{
[TestFixture]
  public class RentalTests
  {
  [Test]
  public void FrequentRenterPointsForRegularMovie()
  {
    var rental = new Rental(new Movie("Test", 0), 1);
    Assert.AreEqual(1,rental.FrequentRenterPoints);
  }
  [Test]
  public void FrequentRenterPointsForRegularMovieRentedFor4Days()
  {
    var rental = new Rental(new Movie("Test", 0), 4);
    Assert.AreEqual(1, rental.FrequentRenterPoints);
  }
  [Test]
  public void FrequentRenterPointsForChildrensMovie()
  {
    var rental = new Rental(new Movie("Test", 2), 1);
    Assert.AreEqual(1, rental.FrequentRenterPoints);
  }
  [Test]
  public void FrequentRenterPointsForChildrensMovieRentedFor4Days()
  {
    var rental = new Rental(new Movie("Test", 2), 4);
    Assert.AreEqual(1, rental.FrequentRenterPoints);
  }
  [Test]
  public void FrequentRenterPointsForNewMovie()
  {
    var rental = new Rental(new Movie("Test", 1), 1);
    Assert.AreEqual(1, rental.FrequentRenterPoints);
  }
  [Test]
  public void FrequentRenterPointsForNewMovieRentedFor4Days()
  {
    var rental = new Rental(new Movie("Test", 1), 4);
    Assert.AreEqual(2, rental.FrequentRenterPoints);
  }
  }
}