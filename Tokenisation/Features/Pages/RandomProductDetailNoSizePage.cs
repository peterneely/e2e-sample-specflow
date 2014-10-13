namespace CTShirts.Web.AcceptanceTests.Tokenisation.Features.Pages
{
    public class RandomProductDetailNoSizePage : BasePage
    {
        public override string AbsolutePath
        {
            get { return Config.RandomProductDetailNoSizeUrl(); }
        }

        public void AddToBag()
        {
            Browser.ClickButton("Add to basket");
        }
    }
}
