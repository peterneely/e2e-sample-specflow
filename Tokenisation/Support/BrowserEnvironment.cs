using System;
using Coypu;
using CTShirts.Infrastructure.Extensions;
using CTShirts.Web.AcceptanceTests.Tokenisation.Features.Pages;

namespace CTShirts.Web.AcceptanceTests.Tokenisation.Support
{
    public class BrowserEnvironment
    {
        private ConfigReader _config;
        private static BrowserSession _browser;
        private readonly Options _optionIncludeHidden = new Options {ConsiderInvisibleElements = true};

        public ConfigReader Config
        {
            get { return _config ?? (_config = new ConfigReader()); }
        }

        public BrowserSession Browser
        {
            get
            {
                return _browser ?? (_browser = new BrowserSession(new SessionConfiguration
                {
                    AppHost = Config.BrowserSetting("baseUrl"),
                    Port = Config.BrowserSetting("port").ToInt(),
                    SSL = Config.BrowserSetting("ssl").ToBool(),
                    Browser = Coypu.Drivers.Browser.Parse(Config.BrowserSetting("browser")),
                    Timeout = TimeSpan.FromSeconds(Config.BrowserSetting("timeout").ToDouble()),
                    RetryInterval = TimeSpan.FromSeconds(Config.BrowserSetting("retryInterval").ToDouble()),
                    ConsiderInvisibleElements = Config.BrowserSetting("considerInvisibleElements").ToBool()
                }));
            }
        }

        public Options IncludeHidden
        {
            get { return _optionIncludeHidden; }
        }

        public T On<T>() where T : BasePage
        {
            var page = Activator.CreateInstance<T>();
            if (AlreadyOn(page)) return page;
            Browser.Visit(page.AbsolutePath);
            return page;
        }

        private bool AlreadyOn<T>(T page) where T : BasePage
        {
            if (typeof (T) == typeof(CurrentPage)) return true;
            var pageUrl = page.AbsolutePath.ToLower();
            var currentUrl = Browser.Location.AbsolutePath.ToLower();
            return pageUrl.StartsWith(currentUrl);
        }

        public static void CloseBrowser()
        {
            if (_browser == null) return;
            _browser.Dispose();
            _browser = null;
        }
    }
}