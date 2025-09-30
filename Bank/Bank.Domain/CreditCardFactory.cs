namespace Bank.Domain
{
    public class CreditCardFactory
    {
        public static ICreditCard? GetCreditCard(string cardType)
        {
            if (cardType == "MoneyBack")
            {
                return new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                return new Titanium();
            }
            else if (cardType == "Platinum")
            {
                return new Platinum();
            }
            else
            {
                return null;
            }
        }
    }
}