// See https://aka.ms/new-console-template for more information
using FactoryMethodDesignPattern;

Console.WriteLine("Hello, World!");

CreditCard creditCard = new PlatinumFactory().CreateProduct();
if (creditCard != null)
{
    Console.WriteLine("Card Type : " + creditCard.GetCardType());
    Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
    Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
}
else
{
    Console.Write("Invalid Card Type");
}
Console.WriteLine("--------------");
creditCard = new MoneyBackFactory().CreateProduct();
if (creditCard != null)
{
    Console.WriteLine("Card Type : " + creditCard.GetCardType());
    Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
    Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
}
else
{
    Console.Write("Invalid Card Type");
}
Console.ReadLine();
