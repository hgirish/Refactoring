using NUnit.Framework;

namespace TheStartingPoint.Tests
{
  // ReSharper disable InconsistentNaming 

  [TestFixture]
  public class CustomerTests
  {


    [Test]
    public void GetChargeShouldBeNonZero()
    {
      var customer = new Customer("test");
      Movie movie = new Movie("test",0);
      Rental rental = new Rental(movie,1);
      customer.AddRental(rental);
     var totalCharge = customer.GetTotalCharge();
     Assert.AreEqual(2, totalCharge);
    }
  }

  // ReSharper restore InconsistentNaming 
}