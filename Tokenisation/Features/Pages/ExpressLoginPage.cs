namespace CTShirts.Web.AcceptanceTests.Tokenisation.Features.Pages
{
    public class ExpressLoginPage : BasePage
    {
        public override string AbsolutePath
        {
            get { return "/login.aspx"; }
        }

        public void Login()
        {
            Browser.FillIn("ctl00_contentBody_email").With(RegisteredCustomer.Email);
            Browser.FindField("ctl00_contentBody_yes_password", IncludeHidden).Click();
            Browser.FindField("password_text_field", IncludeHidden).Click();
            Browser.FillIn("ctl00_contentBody_PasswordTextBox").With(Config.Data("login.UserNoCards.Password"));
            Browser.ClickButton("ctl00_contentBody_submit");
        }
    }
}
