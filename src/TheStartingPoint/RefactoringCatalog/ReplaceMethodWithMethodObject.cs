namespace RefactoringCatalog
{
  public class ReplaceMethodWithMethodObject
  {
    public  int Gamma(int inputVal, int quantity, int yearToDate)
    {
      int importantValue1 = (inputVal * quantity) + Delta();
      int importantValue2 = (inputVal * yearToDate) + 100;
      if ((yearToDate - importantValue1) > 100)
        importantValue2 -= 20;
      int importantValue3 = importantValue2 * 7;
      // and so on.
      return importantValue3 - 2 * importantValue1;
    }
    public int GammaR1(int inputVal, int quantity, int yearToDate)
    {
      return new Gamma(this, inputVal, quantity, yearToDate).Compute();
    }
    public int Delta()
    {
      return 5;
    }


  }

  public class Gamma
  {
    private readonly ReplaceMethodWithMethodObject _account;
    private readonly int _inputVal;
    private readonly int _quantity;
    private readonly int _yearToDate;
    private int _importantValue1;
    private int _importantValue2;

    public Gamma(ReplaceMethodWithMethodObject account, 
    int inputVal, int quantity, int yearToDate)
    {
      _account = account;
      _inputVal = inputVal;
      _quantity = quantity;
      _yearToDate = yearToDate;
    }

    public int Compute()
    {
      _importantValue1 = (_inputVal * _quantity) + _account.Delta();
      _importantValue2 = (_inputVal * _yearToDate) + 100;
      ImportantThing();
      int importantValue3 = _importantValue2 * 7;
      // and so on.
      return importantValue3 - 2 * _importantValue1;

    }

    private void ImportantThing()
    {
      if ((_yearToDate - _importantValue1) > 100)
        _importantValue2 -= 20;
    }
  }
}