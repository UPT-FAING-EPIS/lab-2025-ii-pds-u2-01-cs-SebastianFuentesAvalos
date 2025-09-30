using Bank.Domain;
using Xunit;

namespace Bank.Domain.Tests
{
    public class CreditCardTests
    {
    [Fact]
        public void GivenCreditTypeSelected_WhenRequestCreditCard_ThenNewValidCreditCard()
        {
            string cardType = "MoneyBack";
            ICreditCard? cardDetails = CreditCardFactory.GetCreditCard(cardType);

            Assert.NotNull(cardDetails);
            Assert.False(string.IsNullOrEmpty(cardDetails.GetCardType()));
            Assert.True(cardDetails.GetCreditLimit() >= 0);
            Assert.True(cardDetails.GetAnnualCharge() >= 0);
        }

    [Fact]
        public void MoneyBackFactoryMethod_CreatesValidCard()
        {
            var factory = new MoneyBackFactoryMethod();
            var card = factory.GetCreditCard();
            Assert.NotNull(card);
            Assert.Equal("MoneyBack", card.GetCardType());
            Assert.True(card.GetCreditLimit() >= 0);
            Assert.True(card.GetAnnualCharge() >= 0);
        }

    [Fact]
        public void TitaniumFactoryMethod_CreatesValidCard()
        {
            var factory = new TitaniumFactoryMethod();
            var card = factory.GetCreditCard();
            Assert.NotNull(card);
            Assert.Equal("Titanium Edge", card.GetCardType());
            Assert.True(card.GetCreditLimit() >= 0);
            Assert.True(card.GetAnnualCharge() >= 0);
        }

    [Fact]
        public void PlatinumFactoryMethod_CreatesValidCard()
        {
            var factory = new PlatinumFactoryMethod();
            var card = factory.GetCreditCard();
            Assert.NotNull(card);
            Assert.Equal("Platinum Plus", card.GetCardType());
            Assert.True(card.GetCreditLimit() >= 0);
            Assert.True(card.GetAnnualCharge() >= 0);
        }
    }
}