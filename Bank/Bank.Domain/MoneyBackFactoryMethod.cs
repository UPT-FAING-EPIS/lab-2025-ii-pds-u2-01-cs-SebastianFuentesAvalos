namespace Bank.Domain
{
    /// <summary>
    /// Concrete factory class for creating MoneyBack credit cards.
    /// This class implements the Factory Method design pattern by providing
    /// a specific implementation for creating MoneyBack credit card instances.
    /// </summary>
    public class MoneyBackFactoryMethod : CreditCardFactoryMethod
    {
        /// <summary>
        /// Creates and returns a new MoneyBack credit card instance.
        /// This method implements the abstract factory method from the base class.
        /// </summary>
        /// <returns>A new instance of MoneyBack credit card.</returns>
        public override ICreditCard GetCreditCard()
        {
            return new MoneyBack();
        }
    }
}
