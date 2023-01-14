using FactoryDesignPattern.Interfaces;
using FactoryDesignPattern.Services;

namespace FactoryDesignPattern.Factories
{
    public class CreditCardFactory
    {
        public static CreditCard? GetCreditCard(string cardType)
        {
            if (cardType == "MoneyBack")
                return new MoneyBack();

            else if (cardType == "Titanium")
                return new Titanium();

            else if (cardType == "Platinum")
                return new Platinum();

            return null;
        }
    }
}
