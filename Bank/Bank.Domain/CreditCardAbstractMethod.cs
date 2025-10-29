namespace Bank.Domain
{
    /// <summary>
    /// Abstract factory class that implements the Factory Method design pattern.
    /// This class defines the interface for creating credit card objects but lets
    /// subclasses decide which credit card class to instantiate.
    /// </summary>
    /// <remarks>
    /// The Factory Method pattern is useful when:
    /// - A class cannot anticipate the class of objects it must create
    /// - A class wants its subclasses to specify the objects it creates
    /// - Classes delegate responsibility to one of several helper subclasses
    /// </remarks>
    public abstract class CreditCardFactoryMethod
    {
        /// <summary>
        /// Abstract method that must be implemented by concrete factory classes.
        /// Each concrete factory will create a specific type of credit card.
        /// </summary>
        /// <returns>A concrete implementation of ICreditCard.</returns>
        public abstract ICreditCard GetCreditCard();
    }
}
