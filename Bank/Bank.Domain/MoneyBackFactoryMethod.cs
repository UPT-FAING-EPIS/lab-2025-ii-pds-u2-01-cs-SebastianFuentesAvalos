namespace Bank.Domain
{
    public class MoneyBackFactoryMethod : CreditCardFactoryMethod
    {
        public override ICreditCard GetCreditCard()
        {
            return new MoneyBack();
        }
    }
}
