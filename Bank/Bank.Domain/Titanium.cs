namespace Bank.Domain
{
    /// <summary>
    /// Titanium credit card implementation.
    /// This is a concrete product in the Factory design pattern.
    /// Provides mid-tier benefits with competitive rates.
    /// </summary>
    public class Titanium : ICreditCard
    {
        /// <summary>
        /// Gets the card type for Titanium credit card.
        /// </summary>
        /// <returns>Returns "Titanium Edge" as the card type.</returns>
        public string GetCardType()
        {
            return "Titanium Edge";
        }
        
        /// <summary>
        /// Gets the credit limit for Titanium card.
        /// </summary>
        /// <returns>Returns 25000 as the credit limit.</returns>
        public int GetCreditLimit()
        {
            return 25000;
        }
        
        /// <summary>
        /// Gets the annual charge for Titanium card.
        /// </summary>
        /// <returns>Returns 1500 as the annual charge.</returns>
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
}