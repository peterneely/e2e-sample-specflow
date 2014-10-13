using System;
using System.Collections.Specialized;

namespace CTShirts.Web.AcceptanceTests.Tokenisation.Support
{
    public static class CommonExtensions
    {
        public static string ValueFor(this NameValueCollection settings, string key)
        {
            return settings != null ? settings.Get(key) : string.Empty;
        }

        public static string RandomValue(this NameValueCollection settings)
        {
            if (settings == null) return string.Empty;
            var index = new Random().Next(1, settings.Count);
            var key = settings.Keys[index - 1];
            return settings.ValueFor(key);
        }
    }
}