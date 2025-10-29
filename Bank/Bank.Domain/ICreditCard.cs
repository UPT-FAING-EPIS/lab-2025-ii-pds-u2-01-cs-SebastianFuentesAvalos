namespace Bank.Domain
{
    /// <summary>
    /// Interface that defines the contract for credit card implementations.
    /// This interface is part of the Factory and Factory Method design patterns implementation.
    /// </summary>
    public interface ICreditCard
    {
        /// <summary>
        /// Gets the type/name of the credit card.
        /// </summary>
        /// <returns>A string representing the credit card type.</returns>
        string GetCardType();
        
        /// <summary>
        /// Gets the credit limit for this credit card.
        /// </summary>
        /// <returns>The credit limit as an integer value.</returns>
        int GetCreditLimit();
        
        /// <summary>
        /// Gets the annual charge for this credit card.
        /// </summary>
        /// <returns>The annual charge as an integer value.</returns>
        int GetAnnualCharge();
    }
}