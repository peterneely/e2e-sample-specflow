namespace CTShirts.Web.AcceptanceTests.Tokenisation.Features.Pages
{
    public class PaymentConfirmationPage : BasePage
    {
        public override string AbsolutePath
        {
            get { return "/orderConfirmed.aspx"; }
        }

        public bool PaymentApproved()
        {
            return Browser.Location.AbsolutePath.ToLower().StartsWith(AbsolutePath.ToLower());
        }

        public bool CustomerInformedCardDetailsSaved()
        {
            return CustomerInformedCardDetails(saved: true);
        }

        public bool CustomerInformedOrderCreated()
        {
            return CustomerInformedCardDetails(saved: false);
        }

        private bool CustomerInformedCardDetails(bool saved)
        {
            var title = Browser.FindCss(saved ? "h1.card-saved" : "h1.card-not-saved");
            var linkExists = Browser.HasContent("You can see the order status");
            return title.Exists() && linkExists;
        }
    }
}
