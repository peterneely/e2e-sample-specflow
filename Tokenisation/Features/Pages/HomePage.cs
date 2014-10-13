namespace CTShirts.Web.AcceptanceTests.Tokenisation.Features.Pages
{
    public class HomePage : BasePage
    {
        public override string AbsolutePath
        {
            get { return "/"; }
        }

        public void Login()
        {
            On<LoginPage>().Login();
        }
    }
}