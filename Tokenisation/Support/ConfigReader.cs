using System;
using System.Collections.Specialized;
using System.Configuration;
using Coypu;
using CTShirts.Infrastructure.Extensions;

namespace CTShirts.Web.AcceptanceTests.Tokenisation.Support
{
    public class ConfigReader
    {
        public SessionConfiguration SessionConfig
        {
            get
            {
                return new SessionConfiguration
                {
                    AppHost = BrowserSetting("baseUrl"),
                    Port = BrowserSetting("port").ToInt(),
                    SSL = BrowserSetting("ssl").ToBool(),
                    Browser = Coypu.Drivers.Browser.Parse(BrowserSetting("browser")),
                    Timeout = TimeSpan.FromSeconds(BrowserSetting("timeout").ToDouble()),
                    RetryInterval = TimeSpan.FromSeconds(BrowserSetting("retryInterval").ToDouble()),
                    ConsiderInvisibleElements = BrowserSetting("considerInvisibleElements").ToBool()
                };
            }
        }

        public string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public string Data(string key)
        {
            return Settings("coypu/fakeData").ValueFor(key);
        }

        public string RandomProductDetailNoSizeUrl()
        {
            return Settings("coypu/productDetailNoSizeUrls").RandomValue();
        }

        public string BrowserSetting(string key)
        {
            return Settings("coypu/browserSettings").ValueFor(key);
        }

        private static NameValueCollection Settings(string name)
        {
            return ConfigurationManager.GetSection(name) as NameValueCollection;
        }
    }
}