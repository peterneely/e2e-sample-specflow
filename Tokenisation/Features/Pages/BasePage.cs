using CTShirts.Web.AcceptanceTests.Tokenisation.Support;
using CTShirts.Web.AcceptanceTests.Tokenisation.Support.Fakes.Customers;
using CTShirts.Web.AcceptanceTests.Tokenisation.Support.SqlRepositories;

namespace CTShirts.Web.AcceptanceTests.Tokenisation.Features.Pages
{
    public abstract class BasePage : BrowserEnvironment
    {
        protected static RegisteredCustomer RegisteredCustomer;
        protected static SqlRepo Sql;

        protected BasePage()
        {
            RegisteredCustomer = new RegisteredCustomer();
            Sql = new SqlRepo();
        }

        public abstract string AbsolutePath { get; }
    }
}