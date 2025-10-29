namespace Bank.Domain
{
    /// <summary>
    /// Factory class that implements the Factory design pattern for creating credit cards.
    /// This class encapsulates the object creation logic and provides a single point
    /// of access for creating different types of credit cards.
    /// </summary>
    public class CreditCardFactory
    {
        /// <summary>
        /// Creates a credit card instance based on the specified card type.
        /// This method implements the Factory design pattern by providing
        /// a centralized way to create credit card objects.
        /// </summary>
        /// <param name="cardType">The type of credit card to create. 
        /// Accepted values: "MoneyBack", "Titanium", "Platinum"</param>
        /// <returns>An instance of ICreditCard implementation, or null if the card type is not recognized.</returns>
        /// <example>
        /// <code>
        /// ICreditCard card = CreditCardFactory.GetCreditCard("MoneyBack");
        /// </code>
        /// </example>
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