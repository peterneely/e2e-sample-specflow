using CTShirts.Web.AcceptanceTests.Tokenisation.Features.Pages;
using CTShirts.Web.AcceptanceTests.Tokenisation.Support.Fakes.Cards;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CTShirts.Web.AcceptanceTests.Tokenisation.Features.Steps
{
    [Binding]
    public class Tkn002 : BaseSteps
    {
        [AfterScenario]
        public static void AfterEachScenario()
        {
            CleanUp();
        }

        [Given(@"an online customer with one saved payment card that has not expired")]
        public void GivenAnOnlineCustomerWithOneSavedPaymentCardThatHasNotExpired()
        {
            RegisteredCustomer.CreateWithCards(new Seed {Valid = 1});
        }

        [Given(@"an online customer with one saved payment card that has expired")]
        public void GivenAnOnlineCustomerWithOneSavedPaymentCardThatHasExpired()
        {
            RegisteredCustomer.CreateWithCards(new Seed { Expired = 1 });
        }

        [Given(@"an online customer with one saved payment card that will be approved")]
        public void GivenAnOnlineCustomerWithOneSavedPaymentCardThatWillBeApproved()
        {
            RegisteredCustomer.CreateWithCards(new Seed { Valid = 1 });
        }

        [Given(@"an online customer with one saved payment card that will be declined")]
        public void GivenAnOnlineCustomerWithOneSavedPaymentCardThatWillBeDeclined()
        {
            RegisteredCustomer.CreateWithCards(new Seed { Declined = 1 });
        }

        [Given(@"they add one or more items to their shopping bag")]
        public void GivenTheyAddOneOrMoreItemsToTheirShoppingBag()
        {
            AddRandomProductsToBag(new Range { Min = 1, Max = 3 });
        }

        [Given(@"they are checking out")]
        public void GivenTheyAreCheckingOut()
        {
            On<ShoppingBag>().Checkout();
        }

        [Given(@"they log in with their email and password")]
        public void GivenTheyLogInWithTheirEmailAndPassword()
        {
            On<ExpressLoginPage>().Login();
        }

        [When(@"they are presented with payment options")]
        public void WhenTheyArePresentedWithPaymentOptions()
        {
            On<DeliveryPage>().ContinueToPayment();
        }

        [When(@"they enter the first three digits of their CVV")]
        public void WhenTheyEnterTheFirstThreeDigitsOfTheirCVV()
        {
            Browser.FillIn("token_card_security_number").With(ValidCards.Single.SecurityNumber);
        }

        [When(@"they select the option to make a payment")]
        public void WhenTheySelectTheOptionToMakeAPayment()
        {
            On<PaymentPage>().SubmitPayment();
        }

        [Then(@"their payment is declined")]
        public void ThenTheirPaymentIsDeclined()
        {
            Assert.That(On<PaymentPage>().PaymentDeclined());
        }

        [When(@"their payment is approved")]
        public void WhenTheirPaymentIsApproved()
        {
            Assert.That(On<PaymentConfirmationPage>().PaymentApproved());
        }

        [When(@"their default saved payment card has not expired")]
        public void WhenTheirDefaultSavedPaymentCardHasNotExpired()
        {
            Assert.That(On<PaymentPage>().CardNotExpired());
        }

        [Then(@"display:")]
        public void ThenDisplay(Table table)
        {
            Assert.That(On<PaymentPage>().CardDetailsExist(table));
        }

        [Then(@"show the option to input a new payment method")]
        public void ThenShowTheOptionToInputANewPaymentMethod()
        {
            Assert.That(Browser.FindId("aNewPaymentMethod").Exists());
        }

        [Then(@"do not show the option to choose another existing payment method")]
        public void ThenDoNotShowTheOptionToChooseAnotherExistingPaymentMethod()
        {
            Assert.That(Browser.FindId("aViewSavedCardsAlias").Missing());
        }

        [Then(@"show the option to make a payment")]
        public void ThenShowTheOptionToMakeAPayment()
        {
            Assert.That(Browser.FindId("btnSubmitAlias").Exists());
        }

        [Then(@"disable this option")]
        public void ThenDisableThisOption()
        {
            Assert.That(Browser.FindCss("#btnSubmitAlias input[type='image']:disabled").Exists());
        }

        [Then(@"enable it when the customer inputs three digits of their CVV")]
        public void ThenEnableItWhenTheCustomerInputsThreeDigitsOfTheirCVV()
        {
            Browser.FillIn("token_card_security_number").With(ValidCards.Single.SecurityNumber);
            Assert.That(Browser.FindCss("#btnSubmitAlias input[type='image']:disabled").Missing());
        }
    }
}