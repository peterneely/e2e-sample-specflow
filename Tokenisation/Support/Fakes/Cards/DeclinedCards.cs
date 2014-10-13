using System;
using System.Collections.Generic;

namespace CTShirts.Web.AcceptanceTests.Tokenisation.Support.Fakes.Cards
{
    public class DeclinedCards : BaseCard
    {
        protected override IEnumerable<PaymentCard> Create()
        {
            var cardTemplate = new PaymentCard
            {
                Number = "4999999999999999",
                MaskedNumber = "XXXXXXXXXXXX9999",
                SecurityNumber = "123",
                Type = "AmericanExpress",
                Name = "Do not ship",
                ExpiryYear = DateTime.Now.AddYears(1).Year
            };
            return CreateMultiple(cardTemplate, 12);
        }
    }
}
