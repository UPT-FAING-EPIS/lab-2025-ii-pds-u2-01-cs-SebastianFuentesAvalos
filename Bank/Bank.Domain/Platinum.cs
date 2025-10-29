namespace Bank.Domain
{
    /// <summary>
    /// Platinum credit card implementation.
    /// This is a concrete product in the Factory design pattern.
    /// Provides premium benefits and higher credit limits.
    /// </summary>
    public class Platinum : ICreditCard
    {
        /// <summary>
        /// Gets the card type for Platinum credit card.
        /// </summary>
        /// <returns>Returns "Platinum Plus" as the card type.</returns>
        public string GetCardType()
        {
            return "Platinum Plus";
        }
        
        /// <summary>
        /// Gets the credit limit for Platinum card.
        /// </summary>
        /// <returns>Returns 35000 as the credit limit.</returns>
        public int GetCreditLimit()
        {
            return 35000;
        }
        
        /// <summary>
        /// Gets the annual charge for Platinum card.
        /// </summary>
        /// <returns>Returns 2000 as the annual charge.</returns>
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}