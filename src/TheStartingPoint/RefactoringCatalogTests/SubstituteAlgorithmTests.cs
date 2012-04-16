using NUnit.Framework;
using RefactoringCatalog;

namespace RefactoringCatalogTests
{
  // ReSharper disable InconsistentNaming 

  [TestFixture]
  public class SubstituteAlgorithmTests
  {
   

    [TestCase(new[] { "John", "Mary", "Lisa", "Kent" },  "John")]
    [TestCase(new[] { "Smith", "Mary", "Lisa", "Kent" },  "Kent")]
    [TestCase(new[] { "Paul", "Don", "Lisa", "John" },  "Don")]
    [TestCase(new[] { "Paul", "Lawrence", "Lisa", "Tom" }, "")]
    [TestCase(new string[] { }, "")]
    public void FoundPersonTests(string[] people, string expected)
    {
      var c = new SubstituteAlgorithm();
      Assert.AreEqual(expected,c.FoundPerson(people));
    }

    [TestCase(new[] { "John", "Mary", "Lisa", "Kent" }, "John")]
    [TestCase(new[] { "Smith", "Mary", "Lisa", "Kent" }, "Kent")]
    [TestCase(new[] { "Paul", "Don", "Lisa", "John" }, "Don")]
    [TestCase(new[] { "Paul", "Lawrence", "Lisa", "Tom" }, "")]
    [TestCase(new string[]{}, "")]
    public void FoundPersonR1Tests(string[] people, string expected)
    {
      var c = new SubstituteAlgorithm();
      Assert.AreEqual(expected, c.FoundPersonR1(people));
    }
  }

  // ReSharper restore InconsistentNaming 
}