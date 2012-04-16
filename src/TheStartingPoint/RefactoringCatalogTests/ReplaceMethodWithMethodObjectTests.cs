using NUnit.Framework;
using RefactoringCatalog;

namespace RefactoringCatalogTests
{
  // ReSharper disable InconsistentNaming 

  [TestFixture]
  public class ReplaceMethodWithMethodObjectTests
  {


    [TestCase(2,3,4,734)]
    [TestCase(3,4,5,771)]
    [TestCase(10,20,30,2390)]
    public void TestGamma(int inptuVal, int quantity, int yearToDate, int expected)
    {
      var c = new ReplaceMethodWithMethodObject();
      var d = c.Gamma(inptuVal, quantity, yearToDate);
    Assert.AreEqual(expected, d);
    }

    [TestCase(2, 3, 4, 734)]
    [TestCase(3, 4, 5, 771)]
    [TestCase(10, 20, 30, 2390)]
    public void TestGammaR1(int inptuVal, int quantity, int yearToDate, int expected)
    {
      var c = new ReplaceMethodWithMethodObject();
      var d = c.GammaR1(inptuVal, quantity, yearToDate);
      Assert.AreEqual(expected, d);
    }
  }

  // ReSharper restore InconsistentNaming 
}