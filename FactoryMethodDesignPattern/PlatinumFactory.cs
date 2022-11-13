// See https://aka.ms/new-console-template for more information
namespace FactoryMethodDesignPattern
{
    public class PlatinumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Platinum();
            return product;
        }
    }
}