using System;
using CTShirts.Web.AcceptanceTests.Tokenisation.Features.Pages;
using CTShirts.Web.AcceptanceTests.Tokenisation.Support;
using CTShirts.Web.AcceptanceTests.Tokenisation.Support.Fakes.Cards;
using CTShirts.Web.AcceptanceTests.Tokenisation.Support.SqlRepositories;

namespace CTShirts.Web.AcceptanceTests.Tokenisation.Features.Steps
{
    public abstract class BaseSteps : BrowserEnvironment
    {
        protected static RegisteredCustomerRepo RegisteredCustomer;
        protected static ValidCards ValidCards;
        protected static ExpiredCards ExpiredCards;
        protected static DeclinedCards DeclinedCards;

        protected BaseSteps()
        {
            RegisteredCustomer = new RegisteredCustomerRepo();
            ValidCards = new ValidCards();
            ExpiredCards = new ExpiredCards();
            DeclinedCards = new DeclinedCards();
        }

        public void AddRandomProductsToBag(Range range)
        {
            var randomMax = new Random().Next(range.Min, range.Max);
            for (var i = 1; i <= randomMax; i++)
            {
                On<RandomProductDetailNoSizePage>().AddToBag();
            }
        }

        protected static void CleanUp()
        {
            RegisteredCustomer.Delete();
            CloseBrowser();
        }
    }
}
