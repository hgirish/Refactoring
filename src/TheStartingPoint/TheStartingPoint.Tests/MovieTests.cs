using NUnit.Framework;

namespace TheStartingPoint.Tests
{
  // ReSharper disable InconsistentNaming 

  [TestFixture]
  public class MovieTests
  {


    [Test]
    public void CanCalculateCharegForRegularMovie()
    {
      var movie = new Movie("Test", 0);
      var charge = movie.GetCharge(1);
      Assert.AreEqual(2, charge);
    }

    [Test]
    public void CanCalculateCharegForRegularMovieForMoreThan2Days()
    {
      var movie = new Movie("Test", 0);
      var charge = movie.GetCharge(3);
      Assert.AreEqual(3.5, charge);
    }
    [Test]
    public void CanCalculateCharegForNewReleaseMovie()
    {
      var movie = new Movie("Test", 1);
      var charge = movie.GetCharge(1);
      Assert.AreEqual(3, charge);
    }
    [Test]
    public void CanCalculateCharegForNewMovieForMoreThan2Days()
    {
      var movie = new Movie("Test", 1);
      var charge = movie.GetCharge(3);
      Assert.AreEqual(9, charge);
    }
    [Test]
    public void CanCalculateCharegForChildrensMovie()
    {
      var movie = new Movie("Test", 2);
      var charge = movie.GetCharge(1);
      Assert.AreEqual(1.5, charge);
    }

    [Test]
    public void CanCalculateCharegForChildrensMovieForMoreThan3Days()
    {
      var movie = new Movie("Test", 2);
      var charge = movie.GetCharge(4);
      Assert.AreEqual(3, charge);
    }
  }

  // ReSharper restore InconsistentNaming 
}