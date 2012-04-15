using System;
using NUnit.Framework;
using RefactoringCatalog;

namespace RefactoringCatalogTests
{
  // ReSharper disable InconsistentNaming 

  [TestFixture]
  public class PassByReferenceOrValueTests
  {


    [Test]
    public void NextDateUpdateTest()
    {
      var p = new PassByReferenceOrValue();
      var d = DateTime.Now;
      int beforeDay = d.Day;
      p.NextUpdateDate(d);
      int afterDay = d.Day;
      Assert.AreEqual(beforeDay, afterDay);
    }
    [Test]
    public void NextDateReplaceTest()
    {
      var p = new PassByReferenceOrValue();
      var d = DateTime.Now;
      int beforeDay = d.Day;
      p.NextDateReplace(d);
      int afterDay = d.Day;
      Assert.AreEqual(beforeDay , afterDay);
    }
  }

  // ReSharper restore InconsistentNaming 
}