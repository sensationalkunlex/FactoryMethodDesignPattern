// See https://aka.ms/new-console-template for more information
namespace FactoryMethodDesignPattern
{
    public class TitaniumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Titanium();
            return product;
        }
    }
}