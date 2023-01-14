using FactoryDesignPattern.Interfaces;

namespace FactoryDesignPattern.Services
{
    public class Platinum : CreditCard
    {
        public string GetCardType() => "Platinum Plus";
        public int GetCreditLimit() => 35000;
        public int GetAnnualCharge() => 2000;
    }
}
