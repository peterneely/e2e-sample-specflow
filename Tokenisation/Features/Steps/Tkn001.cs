using CTShirts.Web.AcceptanceTests.Tokenisation.Features.Pages;
using CTShirts.Web.AcceptanceTests.Tokenisation.Support.Fakes.Cards;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CTShirts.Web.AcceptanceTests.Tokenisation.Features.Steps
{
    [Binding]
    public class Tkn001 : BaseSteps
    {
        private int _customerId;

        [AfterScenario]
        public static void AfterEachScenario()
        {
            CleanUp();
        }

        [Given(@"an online customer with no saved payment cards adds one or more items to their shopping bag")]
        public void GivenAnOnlineCustomerWithNoSavedPaymentCardsAddsOneOrMoreItemsToTheirShoppingBag()
        {
            _customerId = RegisteredCustomer.Create();
            AddRandomProductsToBag(new Range {Min = 1, Max = 3});
        }

        [Given(@"they checkout")]
        public void GivenTheyCheckout()
        {
            On<ShoppingBag>().Checkout();
        }

        [Given(@"they login with their email and password")]
        public void GivenTheyLoginWithTheirEmailAndPassword()
        {
            On<ExpressLoginPage>().Login();
        }

        [Given(@"they are presented with payment options")]
        public void GivenTheyArePresentedWithPaymentOptions()
        {
            On<DeliveryPage>().ContinueToPayment();
        }

        [Given(@"they select to pay by card")]
        public void GivenTheySelectToPayByCard()
        {
            On<PaymentPage>().SelectCard();
        }

        [Given(@"they see the default form for entering new payment card details")]
        public void GivenTheySeeTheDefaultFormForEnteringNewPaymentCardDetails()
        {
            Assert.That(On<PaymentPage>().CanEnterCardDetails());
        }

        [Given(@"they input valid card details")]
        public void GivenTheyInputValidCardDetails()
        {
            On<PaymentPage>().EnterDetails(ValidCards.Single);
        }

        [Given(@"they input invalid card details")]
        public void GivenTheyInputInvalidCardDetails()
        {
            On<PaymentPage>().EnterDetails(DeclinedCards.Single);
        }

        [Given(@"an option to save their card details is not selected")]
        public void GivenAnOptionToSaveTheirCardDetailsIsNotSelected()
        {
            Assert.That(On<PaymentPage>().SaveCardDetailsSelected(false));
        }

        [Given(@"they select the option to save their card details")]
        public void GivenTheySelectTheOptionToSaveTheirCardDetails()
        {
            On<PaymentPage>().SelectSaveCardDetails(true);
        }

        [Given(@"they ""(.*)"" that option")]
        public void GivenTheyThatOption(string selectOrNot)
        {
            On<PaymentPage>().SelectSaveCardDetails(selectOrNot == "select");
        }

        [When(@"they submit payment")]
        public void WhenTheySubmitPayment()
        {
            On<PaymentPage>().SubmitPayment();
        }

        [When(@"payment is approved")]
        public void WhenPaymentIsApproved()
        {
            Assert.That(On<PaymentConfirmationPage>().PaymentApproved());
        }

        [When(@"payment is declined")]
        public void WhenPaymentIsDeclined()
        {
            Assert.That(On<PaymentPage>().PaymentDeclined());
        }

        [Then(@"the card details are saved to their account as the default payment card")]
        public void ThenTheCardDetailsAreSavedToTheirAccountAsTheDefaultPaymentCard()
        {
            Assert.That(On<CurrentPage>().CardDetailsSavedFor(_customerId));
        }

        [Then(@"they are informed that their order has been created and their details have been saved")]
        public void ThenTheyAreInformedThatTheirOrderHasBeenCreatedAndTheirDetailsHaveBeenSaved()
        {
            Assert.That(On<PaymentConfirmationPage>().CustomerInformedCardDetailsSaved());
        }

        [Then(@"the card details are not saved to their account")]
        public void ThenTheCardDetailsAreNotSavedToTheirAccount()
        {
            Assert.That(On<CurrentPage>().CardDetailsNotSavedFor(_customerId));
        }

        [Then(@"they are informed that their order has been created")]
        public void ThenTheyAreInformedThatTheirOrderHasBeenCreated()
        {
            Assert.That(On<PaymentConfirmationPage>().CustomerInformedOrderCreated());
        }
    }
}