// See https://aka.ms/new-console-template for more information
public class MoneyBack : CreditCard
{
    public string GetCardType()
    {
        return "MoneyBack";
    }
    public int GetCreditLimit()
    {
        return 15000;
    }
    public int GetAnnualCharge()
    {
        return 500;
    }
}