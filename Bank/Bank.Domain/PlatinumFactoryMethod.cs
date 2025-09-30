namespace Bank.Domain
{
    public class PlatinumFactoryMethod : CreditCardFactoryMethod
    {
        public override ICreditCard GetCreditCard()
        {
            return new Platinum();
        }
    }
}
