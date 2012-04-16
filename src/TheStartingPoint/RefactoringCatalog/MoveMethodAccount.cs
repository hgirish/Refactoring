namespace RefactoringCatalog
{
  public  class MoveMethodAccount
  {
    public double OverdraftCharge()
    {
      if (_type.IsPremium())
      {
        double result = 10;
        if (DaysOverdrawn > 7) result += (DaysOverdrawn - 7) * 0.85;
        return result;
      }
      else return DaysOverdrawn * 1.75;
    }
    //public double OverdraftChargeR1()
    //{
    //  return _type.OverdraftCharge(DaysOverdrawn);
    //}
  public   double BankCharge()
    {
      double result = 4.5;
      if (DaysOverdrawn > 0) result += OverdraftCharge();
      return result;
    }
  public double BankChargeR1()
  {
    double result = 4.5;
    if (DaysOverdrawn > 0) result += _type.OverdraftCharge(this);
    return result;
  }
    private readonly AccountType _type;

    public MoveMethodAccount(AccountType type, int daysOverdrawn)
    {
      _type = type;
      DaysOverdrawn = daysOverdrawn;
    }

    public int DaysOverdrawn { get; set; }
  }

  public class AccountType
  {
    private readonly bool _isPremium;

    public AccountType(bool isPremium)
    {
      _isPremium = isPremium;
    }

    public bool IsPremium()
    {
      return _isPremium;
    }

    public double OverdraftCharge(int daysOverdrawn)
    {
      if (IsPremium())
      {
        double result = 10;
        if (daysOverdrawn > 7) result += (daysOverdrawn - 7) * 0.85;
        return result;
      }
      else return daysOverdrawn * 1.75;
    }
    public double OverdraftCharge(MoveMethodAccount account)
    {
      if (IsPremium())
      {
        double result = 10;
        if (account.DaysOverdrawn > 7) result += (account.DaysOverdrawn - 7) * 0.85;
        return result;
      }
      else return account.DaysOverdrawn * 1.75;
    }
  }
}