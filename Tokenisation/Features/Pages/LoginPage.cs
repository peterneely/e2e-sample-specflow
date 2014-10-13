namespace CTShirts.Web.AcceptanceTests.Tokenisation.Features.Pages
{
    public class LoginPage : BasePage
    {
        public override string AbsolutePath
        {
            get { return "/AccountLogin.aspx"; }
        }

        public void Login()
        {
            Browser.FillIn("ctl00_contentBody_email").With(RegisteredCustomer.Email);
            Browser.FillIn("ctl00_contentBody_password").With(Config.Data("login.UserNoCards.Password"));
            Browser.ClickButton("ctl00_contentBody_submit");
        }
    }
}
