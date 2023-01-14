using FactoryDesignPattern.Interfaces;

namespace FactoryDesignPattern.Services
{
    public class Titanium : CreditCard
    {
        public string GetCardType() => "Titanium Edge";
        public int GetCreditLimit() => 25000;
        public int GetAnnualCharge() => 1500;
    }
}
