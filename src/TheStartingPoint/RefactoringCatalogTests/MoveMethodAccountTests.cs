using NUnit.Framework;
using RefactoringCatalog;

namespace RefactoringCatalogTests
{
  // ReSharper disable InconsistentNaming 

  [TestFixture]
  public class MoveMethodAccountTests
  {
    private AccountType _accountType;

    
    [TestCase(true,3, 14.5)]
    [TestCase(true,10, 14.5)]
    [TestCase(false, 3, 9.75)]
    [TestCase(false, 10, 9.75)]
    public void OverdraftChargeTest(bool isPremium, int daysOverdrawn, double expectedCharge)
    {
      _accountType = new AccountType(isPremium);
      var c = new MoveMethodAccount(_accountType, 3);
     // double overdraftCharge = c.OverdraftCharge();
      var bankCharge = c.BankCharge();

     // Assert.AreEqual(expectedCharge, overdraftCharge);
      Assert.AreEqual(expectedCharge,bankCharge);
    }

    //[TestCase(true, 3, 10)]
    //[TestCase(true, 10, 10)]
    //[TestCase(false, 3, 5.25)]
    //[TestCase(false, 10, 5.25)]
    //public void OverdraftChargeR1Test(bool isPremium, int daysOverdrawn, double expectedCharge)
    //{
    //  _accountType = new AccountType(isPremium);
    //  var c = new MoveMethodAccount(_accountType, 3);
    //  double overdraftCharge = c.OverdraftChargeR1();
    //  Assert.AreEqual(expectedCharge, overdraftCharge);
    //}

    [TestCase(true, 3, 14.5)]
    [TestCase(true, 10, 14.5)]
    [TestCase(false, 3, 9.75)]
    [TestCase(false, 10, 9.75)]
    public void BankChargeR1Test(bool isPremium, int daysOverdrawn, double expectedCharge)
    {
      _accountType = new AccountType(isPremium);
      var c = new MoveMethodAccount(_accountType, 3);
      // double overdraftCharge = c.OverdraftCharge();
      var bankCharge = c.BankChargeR1();

      // Assert.AreEqual(expectedCharge, overdraftCharge);
      Assert.AreEqual(expectedCharge, bankCharge);
    }
  }

  // ReSharper restore InconsistentNaming 
}