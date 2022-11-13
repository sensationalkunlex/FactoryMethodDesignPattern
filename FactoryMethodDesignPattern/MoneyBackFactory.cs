// See https://aka.ms/new-console-template for more information
namespace FactoryMethodDesignPattern
{
    public class MoneyBackFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new MoneyBack();
            return product;
        }
    }
}