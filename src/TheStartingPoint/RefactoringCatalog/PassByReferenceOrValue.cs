using System;

namespace RefactoringCatalog
{
  public class PassByReferenceOrValue
  {
    public DateTime NextUpdateDate(DateTime arg)
    {
      arg = arg.AddDays(1);
      Console.WriteLine("Arg in nextDay: {0:d}", arg);
      return arg;
    } 
    public DateTime NextDateReplace(DateTime arg)
    {
      arg = new DateTime(arg.Year,arg.Month,arg.Day+1);
      Console.WriteLine("Arg in nextDay: {0:d}", arg);
      return arg;
    }
  }
}