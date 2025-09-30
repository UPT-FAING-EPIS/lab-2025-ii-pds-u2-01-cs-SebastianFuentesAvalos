namespace Bank.Domain
{
    public class TitaniumFactoryMethod : CreditCardFactoryMethod
    {
        public override ICreditCard GetCreditCard()
        {
            return new Titanium();
        }
    }
}
