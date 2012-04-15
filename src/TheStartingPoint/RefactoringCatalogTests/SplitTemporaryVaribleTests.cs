using NUnit.Framework;
using RefactoringCatalog;

namespace RefactoringCatalogTests
{
  // ReSharper disable InconsistentNaming 

  [TestFixture]
  public class SplitTemporaryVaribleTests
  {


    [Test]
    public void PrintTests()
    {
      var t = new SplitTemporaryVariable();
       t.Print(2, 4);
      t.PrintR1(2, 4);
    }

    [Test]
    public void GetDistanceTravelledTest()
    {

      var t = new SplitTemporaryVariable {Delay = 10, Mass = 10, PrimaryForce = 10, SecondaryForce = 10};
      var distance = t.GetDistanceTravelled(10);
      Assert.AreEqual(50, distance);

    }
    [Test]
    public void GetDistanceTravelledR1Test()
    {

      var t = new SplitTemporaryVariable { Delay = 10, Mass = 10, PrimaryForce = 10, SecondaryForce = 10 };
      var distance = t.GetDistanceTravelledR1(10);
      Assert.AreEqual(50, distance);

    }
     
    [Test]
    public void GetDistanceTravelledR2Test()
    {

      var t = new SplitTemporaryVariable { Delay = 10, Mass = 10, PrimaryForce = 10, SecondaryForce = 10 };
      var distance = t.GetDistanceTravelledR2(10);
      Assert.AreEqual(50, distance);

    }
  }

  // ReSharper restore InconsistentNaming 
}