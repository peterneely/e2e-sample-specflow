using CTShirts.Web.AcceptanceTests.Tokenisation.Support.Fakes.Cards;
using TechTalk.SpecFlow;

namespace CTShirts.Web.AcceptanceTests.Tokenisation.Features.Steps
{
    [Binding]
    public class Tkn003 : BaseSteps
    {
        [AfterScenario]
        public static void AfterEachScenario()
        {
            CleanUp();
        }

        [Given(@"an online customer with at least two saved payment cards, all of which are valid")]
        public void GivenAnOnlineCustomerWithAtLeastTwoSavedPaymentCardsAllOfWhichAreValid()
        {
            var seed = new RandomSeed {Valid = new Range {Min = 2, Max = 12}};
            RegisteredCustomer.CreateWithRandomCards(seed);
        }
    }
}