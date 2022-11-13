﻿// See https://aka.ms/new-console-template for more information
class CreditCardFactory
{
    public static CreditCard GetCreditCard(string cardType)
    {
        CreditCard cardDetails = null;
        if (cardType == "MoneyBack")
        {
            cardDetails = new MoneyBack();
        }
        else if (cardType == "Titanium")
        {
            cardDetails = new Titanium();
        }
        else if (cardType == "Platinum")
        {
            cardDetails = new Platinum();
        }
        return cardDetails;
    }
}