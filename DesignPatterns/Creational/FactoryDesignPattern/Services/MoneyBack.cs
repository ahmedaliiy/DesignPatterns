using FactoryDesignPattern.Interfaces;

namespace FactoryDesignPattern.Services
{
    public class MoneyBack : CreditCard
    {
        public string GetCardType() => "MoneyBack";
        public int GetCreditLimit() => 15000;
        public int GetAnnualCharge() => 500;
    }
}
