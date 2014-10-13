namespace CTShirts.Web.AcceptanceTests.Tokenisation.Features.Pages
{
    public class ShoppingBag : BasePage
    {
        public override string AbsolutePath
        {
            get { return "/ShoppingBag.aspx"; }
        }

        public void Checkout()
        {
            Browser.ClickButton("ctl00_contentBody_submit");
        }
    }
}
