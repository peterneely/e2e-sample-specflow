namespace CTShirts.Web.AcceptanceTests.Tokenisation.Features.Pages
{
    public class DeliveryPage : BasePage
    {
        public override string AbsolutePath
        {
            get { return "/Delivery.aspx"; }
        }

        public void ContinueToPayment()
        {
            Browser.ClickButton("ctl00_contentBody_submit");
            On<PaymentPage>().ContinueToPageTwo();
        }
    }
}
