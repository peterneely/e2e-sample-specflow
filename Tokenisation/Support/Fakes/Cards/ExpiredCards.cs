using System;
using System.Collections.Generic;

namespace CTShirts.Web.AcceptanceTests.Tokenisation.Support.Fakes.Cards
{
    public class ExpiredCards : BaseCard
    {
        protected override IEnumerable<PaymentCard> Create()
        {
            var cardTemplate = new PaymentCard
            {
                Number = "4111111111111121",
                MaskedNumber = "XXXXXXXXXXXX1121",
                SecurityNumber = "123",
                Type = "MasterCard",
                Name = "Do not ship",
                ExpiryYear = DateTime.Now.AddYears(-1).Year
            };
            return CreateMultiple(cardTemplate, 12);
        }
    }
}
