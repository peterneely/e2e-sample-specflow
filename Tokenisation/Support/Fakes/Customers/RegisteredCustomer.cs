namespace CTShirts.Web.AcceptanceTests.Tokenisation.Support.Fakes.Customers
{
    public class RegisteredCustomer : GuestCustomer
    {
        public RegisteredCustomer()
        {
            Password = Config.Data("login.UserNoCards.Password");
            Greeting = Config.Data("login.UserNoCards.Greeting");
            FirstName = UserFirstName();
            LastName = UserLastName();
            Address = Config.Data("login.UserNoCards.Address");
            Town = Config.Data("login.UserNoCards.Town");
            CountryCode = Config.Data("login.UserNoCards.CountryCode");
            PostCode = Config.Data("login.UserNoCards.PostCode");
            DaytimePhone = Config.Data("login.UserNoCards.DaytimePhone");
        }

        public string Password { get; private set; }
        public string Greeting { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Address { get; private set; }
        public string Town { get; private set; }
        public string CountryCode { get; private set; }
        public string PostCode { get; private set; }
        public string DaytimePhone { get; private set; }

        private static string UserFirstName()
        {
            return Name(0);
        }

        private static string UserLastName()
        {
            return Name(1);
        }
    }
}
