namespace Bank.Domain
{
    /// <summary>
    /// Concrete factory class for creating Platinum credit cards.
    /// This class implements the Factory Method design pattern by providing
    /// a specific implementation for creating Platinum credit card instances.
    /// </summary>
    public class PlatinumFactoryMethod : CreditCardFactoryMethod
    {
        /// <summary>
        /// Creates and returns a new Platinum credit card instance.
        /// This method implements the abstract factory method from the base class.
        /// </summary>
        /// <returns>A new instance of Platinum credit card.</returns>
        public override ICreditCard GetCreditCard()
        {
            return new Platinum();
        }
    }
}
