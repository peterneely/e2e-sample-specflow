using System;
using System.Collections.Generic;

namespace CTShirts.Web.AcceptanceTests.Tokenisation.Support.Fakes.Cards
{
    public class ValidCards : BaseCard
    {
        protected override IEnumerable<PaymentCard> Create()
        {
            var cardTemplate = new PaymentCard
            {
                Number = "4111111111111111",
                MaskedNumber = "XXXXXXXXXXXX1111",
                SecurityNumber = "123",
                Type = "VISA",
                Name = "Do not ship",
                ExpiryYear = DateTime.Now.AddYears(1).Year
            };
            return CreateMultiple(cardTemplate, 12);
        }
    }
}
