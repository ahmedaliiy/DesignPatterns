using FactoryDesignPattern.Constants;
using FactoryDesignPattern.Factories;
using FactoryDesignPattern.Interfaces;

CreditCard? cardDetails = CreditCardFactory.GetCreditCard(CreditCardTypes.MoneyBack);

if (cardDetails is not null)
{
    Console.WriteLine("CardType : " + cardDetails.GetCardType());
    Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
    Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
}
else
    Console.Write("Invalid Card Type");

Console.ReadLine();
