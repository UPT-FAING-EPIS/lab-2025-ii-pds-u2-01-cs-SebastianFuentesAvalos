namespace Bank.Domain
{
    /// <summary>
    /// MoneyBack credit card implementation.
    /// This is a concrete product in the Factory design pattern.
    /// Provides basic credit card benefits with money back rewards.
    /// </summary>
    public class MoneyBack : ICreditCard
    {
        /// <summary>
        /// Gets the card type for MoneyBack credit card.
        /// </summary>
        /// <returns>Returns "MoneyBack" as the card type.</returns>
        public string GetCardType()
        {
            return "MoneyBack";
        }
        
        /// <summary>
        /// Gets the credit limit for MoneyBack card.
        /// </summary>
        /// <returns>Returns 15000 as the credit limit.</returns>
        public int GetCreditLimit()
        {
            return 15000;
        }
        
        /// <summary>
        /// Gets the annual charge for MoneyBack card.
        /// </summary>
        /// <returns>Returns 500 as the annual charge.</returns>
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}