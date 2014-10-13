using CTShirts.Web.AcceptanceTests.Tokenisation.Support.Fakes.Cards;
using CTShirts.Web.AcceptanceTests.Tokenisation.Support.SqlRepositories;
using NUnit.Framework;

namespace CTShirts.Web.AcceptanceTests.Tokenisation.Support
{
    public class SeedDatabase
    {
        private readonly RegisteredCustomerRepo _registeredCustomer = new RegisteredCustomerRepo();

        [Test]
        public void Create_registered_customer_0_cards()
        {
            _registeredCustomer.Create();
        }

        [Test]
        public void Create_registered_customer_1_valid_card()
        {
            _registeredCustomer.CreateWithCards(new Seed {Valid = 1});
        }

        [Test]
        public void Create_registered_customer_2_or_more_valid_cards()
        {
            var seed = new RandomSeed
            {
                Valid = new Range {Min = 2, Max = 10},
            };
            _registeredCustomer.CreateWithRandomCards(seed);
        }

        [Test]
        public void Create_registered_customer_2_or_more_valid_some_expired_cards()
        {
            var seed = new RandomSeed
            {
                Valid = new Range {Min = 2, Max = 10},
                Expired = new Range {Min = 1, Max = 5}
            };
            _registeredCustomer.CreateWithRandomCards(seed);
        }

        [Test]
        public void Create_registered_customer_2_or_more_expired_cards()
        {
            var seed = new RandomSeed
            {
                Expired = new Range { Min = 2, Max = 10 }
            };
            _registeredCustomer.CreateWithRandomCards(seed);
        }

        [Test]
        public void Delete_registered_customer()
        {
            _registeredCustomer.Delete();
        }
    }
}