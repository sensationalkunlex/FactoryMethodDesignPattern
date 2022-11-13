// See https://aka.ms/new-console-template for more information
public abstract class CreditCardFactory
{
    protected abstract CreditCard MakeProduct();
    public CreditCard CreateProduct()
    {
        return this.MakeProduct();
    }
}