// See https://aka.ms/new-console-template for more information
public class Platinum : CreditCard
{
    public string GetCardType()
    {
        return "Platinum Plus";
    }
    public int GetCreditLimit()
    {
        return 35000;
    }
    public int GetAnnualCharge()
    {
        return 2000;
    }
}
