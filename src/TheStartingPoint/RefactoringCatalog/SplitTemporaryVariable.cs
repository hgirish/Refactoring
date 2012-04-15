using System;

namespace RefactoringCatalog
{
  public class SplitTemporaryVariable
  {
    public double PrimaryForce { get; set; }

    public double SecondaryForce { get; set; }

    public int Delay { get; set; }

    public double Mass { get; set; }

    public void Print(int height, int width)
    {
      double temp = 2*(height + width);
      Console.WriteLine(temp);
      temp = height*width;
      Console.WriteLine(temp);
    }

    public void PrintR1(int height, int width)
    {
      double  perimeter = 2*(height + width);
      Console.WriteLine(perimeter);
      double area = height*width;
      Console.WriteLine(area);
    }

  public   double GetDistanceTravelled(int time)
    {
      double result;
      double acc = PrimaryForce/Mass;
      int primaryTime = Math.Min(time, Delay);
      result = 0.5*acc*primaryTime*primaryTime;
      int secondaryTime = time - Delay;
      if (secondaryTime > 0)
      {
        double primaryVel = acc*Delay;
        acc = (PrimaryForce + SecondaryForce)/Mass;
        result += primaryVel*secondaryTime + 0.5*acc*secondaryTime*secondaryTime;
      }
      return result;
    }

    public double GetDistanceTravelledR1(int time)
    {
      double result;
      double primaryAcc = PrimaryForce / Mass; // renamed acc to PrimaryAcc
      int primaryTime = Math.Min(time, Delay);
      result = 0.5 * primaryAcc * primaryTime * primaryTime;
      int secondaryTime = time - Delay;
      if (secondaryTime > 0)
      {
        double primaryVel = primaryAcc * Delay;
        primaryAcc = (PrimaryForce + SecondaryForce) / Mass;
        result += primaryVel * secondaryTime + 0.5 * primaryAcc * secondaryTime * secondaryTime;
      }
      return result;
    }
    public double GetDistanceTravelledR2(int time)
    {
      double result;
      double primaryAcc = PrimaryForce / Mass; // renamed acc to PrimaryAcc
      int primaryTime = Math.Min(time, Delay);
      result = 0.5 * primaryAcc * primaryTime * primaryTime;
      int secondaryTime = time - Delay;
      if (secondaryTime > 0)
      {
        double primaryVel = primaryAcc * Delay;
        double secondaryAcc = (PrimaryForce + SecondaryForce) / Mass; // introduce seconday acc
        result += primaryVel * secondaryTime + 0.5 * secondaryAcc * secondaryTime * secondaryTime;
      }
      return result;
    }
  }
}