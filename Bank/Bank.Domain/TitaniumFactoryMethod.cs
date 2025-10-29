namespace Bank.Domain
{
    /// <summary>
    /// Concrete factory class for creating Titanium credit cards.
    /// This class implements the Factory Method design pattern by providing
    /// a specific implementation for creating Titanium credit card instances.
    /// </summary>
    public class TitaniumFactoryMethod : CreditCardFactoryMethod
    {
        /// <summary>
        /// Creates and returns a new Titanium credit card instance.
        /// This method implements the abstract factory method from the base class.
        /// </summary>
        /// <returns>A new instance of Titanium credit card.</returns>
        public override ICreditCard GetCreditCard()
        {
            return new Titanium();
        }
    }
}
