using System.Collections.Generic;
using System.Linq;

namespace RefactoringCatalog
{
  public class SubstituteAlgorithm
  {
   public  string FoundPerson(string[] people)
    {
      for (int i = 0; i < people.Length; i++)
      {
        if (people[i].Equals("Don"))
        {
          return "Don";
        }
        if (people[i].Equals("John"))
        {
          return "John";
        }
        if (people[i].Equals("Kent"))
        {
          return "Kent";
        }
      }
      return "";
    }

  public  string FoundPersonR1(string[] people)
   {
     var candidates = new List<string> {"Don", "John", "Kent"};

     foreach (var t in people.Where(candidates.Contains))
       return t;
    return "";
   }

  }
}