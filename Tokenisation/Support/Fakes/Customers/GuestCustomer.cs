using System.Globalization;

namespace CTShirts.Web.AcceptanceTests.Tokenisation.Support.Fakes.Customers
{
    public class GuestCustomer
    {
        protected ConfigReader Config;
        private static readonly string UserName = System.Environment.UserName;
        private const char DelimeterChar = '.';
        private static readonly string DelimeterString = DelimeterChar.ToString(CultureInfo.InvariantCulture);

        public GuestCustomer()
        {
            Config = new BrowserEnvironment().Config;
            Email = UserEmail();
        }

        public string Email { get; private set; }
        public int CustomerId { get; set; }

        protected static string UserEmail()
        {
            var email = UserName.Contains(DelimeterString) ? string.Format("{0}.fake@ctshirts.co.uk", UserName) : "test@ctshirts.co.uk";
            return email.ToLower();
        }

        protected static string Name(int index)
        {
            return UserName.Contains(DelimeterString) ? UserName.Split(DelimeterChar)[index] : UserName;
        }
    }
}
