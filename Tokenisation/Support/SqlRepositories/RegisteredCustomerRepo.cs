using System;
using System.Collections.Generic;
using System.Linq;
using CTShirts.Infrastructure.Extensions;
using CTShirts.Web.AcceptanceTests.Tokenisation.Support.Fakes.Cards;
using CTShirts.Web.AcceptanceTests.Tokenisation.Support.Fakes.Customers;

namespace CTShirts.Web.AcceptanceTests.Tokenisation.Support.SqlRepositories
{
    public class RegisteredCustomerRepo
    {
        private readonly SqlRepo _sql = new SqlRepo();
        private readonly RegisteredCustomer _customer = new RegisteredCustomer();

        public int Create()
        {
            Delete();
            var result = _sql.ExecuteStoredProcedure("spiTestRegisteredCustomer",
                new
                {
                    email = _customer.Email,
                    password = _customer.Password,
                    greeting = _customer.Greeting,
                    firstName = _customer.FirstName,
                    lastName = _customer.LastName,
                    address = _customer.Address,
                    town = _customer.Town,
                    countryCode = _customer.CountryCode,
                    postCode = _customer.PostCode,
                    daytimePhone = _customer.DaytimePhone,
                    _customerId = 0
                });
            return result.OutputValues["customerId"].ToInt();
        }

        public void CreateWithCards(Seed seed)
        {
            var cards = CreateCards(seed);
            CreateWithTheseCards(cards);
        }

        public void CreateWithRandomCards(RandomSeed seed)
        {
            var cards = CreateRandomCards(seed);
            CreateWithTheseCards(cards);
        }

        private void CreateWithTheseCards(IEnumerable<PaymentCard> cards)
        {
            Delete();
            var customerId = Create();
            cards.ForEach(c => _sql.ExecuteStoredProcedure("spiPaymentToken",
                new
                {
                    _Id = 0,
                    AliasId = LongRandom(1111111111111111, 9999999999999999, new Random()).String(),
                    CardNumber = c.MaskedNumber,
                    CustomerNo = customerId,
                    CardType = c.Type,
                    CardHoldersName = c.Name,
                    CardExpiryMonth = c.ExpiryMonth,
                    CardExpiryYear = c.ExpiryYear.String().Right(2)
                }));
        }

        private static long LongRandom(long min, long max, Random rand)
        {
            var buf = new byte[8];
            rand.NextBytes(buf);
            var longRand = BitConverter.ToInt64(buf, 0);
            return (Math.Abs(longRand % (max - min)) + min);
        }


        public void Delete()
        {
            _sql.ExecuteStoredProcedure("spdTestRegisteredCustomer",
                new
                {
                    email = _customer.Email,
                    daytimePhone = _customer.DaytimePhone
                });
        }

        private static IEnumerable<PaymentCard> CreateCards(Seed seed)
        {
            var validCards = Take(new ValidCards().All, seed.Valid);
            var expiredCards = Take(new ExpiredCards().All, seed.Expired);
            var declinedCards = Take(new DeclinedCards().All, seed.Declined);
            return validCards.Union(expiredCards).Union(declinedCards);
        }

        private static IEnumerable<PaymentCard> CreateRandomCards(RandomSeed seed)
        {
            var noCards = new List<PaymentCard>();
            var validCards = seed.Valid != null
                ? Take(new ValidCards().All, Random(seed.Valid.Min, seed.Valid.Max))
                : noCards;
            var expiredCards = seed.Expired != null
                ? Take(new ExpiredCards().All, Random(seed.Expired.Min, seed.Expired.Max))
                : noCards;
            var declinedCards = seed.Declined != null
                ? Take(new DeclinedCards().All, Random(seed.Declined.Min, seed.Declined.Max))
                : noCards;
            return validCards.Union(expiredCards).Union(declinedCards);
        }

        private static int Random(int min, int max)
        {
            if (max == 0) return 0;
            var random = new Random();
            return random.Next(min, max);
        }

        private static IEnumerable<PaymentCard> Take(IEnumerable<PaymentCard> cards, int required)
        {
            if (required == 0) return new List<PaymentCard>();
            var allCards = cards.ToList();
            var max = allCards.Count();
            return allCards.Take(required <= max ? required : max);
        }
    }
}
