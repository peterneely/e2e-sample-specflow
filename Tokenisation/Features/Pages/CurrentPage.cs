namespace CTShirts.Web.AcceptanceTests.Tokenisation.Features.Pages
{
    public class CurrentPage : BasePage
    {
        public override string AbsolutePath
        {
            get { return Browser.Location.AbsolutePath; }
        }

        public bool CardDetailsSavedFor(int customerId)
        {
            return DetailsSavedFor(customerId);
        }

        public bool CardDetailsNotSavedFor(int customerId)
        {
            return !DetailsSavedFor(customerId);
        }

        private static bool DetailsSavedFor(int customerId)
        {
            var query = string.Format("select top 1 AliasId from tbPaymentToken where CustomerNo = {0} order by Id desc", customerId);
            var aliasId = Sql.GetValue<string>(query);
            var cardSaved = aliasId != default(string);

            query = string.Format("select top 1 OrderNo from tbOrder where CustomerNo = {0} and AliasId = {1} order by OrderNo desc", customerId, aliasId);
            var orderId = Sql.GetValue<int>(query);
            var orderUpdated = orderId != default(int);

            return cardSaved && orderUpdated;
        }
    }
}
