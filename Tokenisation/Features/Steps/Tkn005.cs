using CTShirts.Web.AcceptanceTests.Tokenisation.Features.Pages;
using TechTalk.SpecFlow;

namespace CTShirts.Web.AcceptanceTests.Tokenisation.Features.Steps
{
    [Binding]
    public class Tkn005 : BaseSteps
    {
        [AfterFeature]
        public static void AfterEachFeature()
        {
            CleanUp();
        }

        [Given(@"an online customer with no saved payment cards has logged in to their account")]
        public void GivenAnOnlineCustomerWithNoSavedPaymentCardsHasLoggedInToTheirAccount()
        {
            RegisteredCustomer.Create();
            On<HomePage>().Login();
        }

        [When(@"they view their account details")]
        public void WhenTheyViewTheirAccountDetails()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"they should not see payment details")]
        public void ThenTheyShouldNotSeePaymentDetails()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"they log into their account")]
        public void GivenTheyLogIntoTheirAccount()
        {
            On<HomePage>().Login();
        }
    }
}