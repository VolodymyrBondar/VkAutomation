using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace VkAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string BaseUrl
        {
            get { return "http://vk.com"; }
        }

        public static void Initialize()
        {
            Instance = new FirefoxDriver();
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        public static void Close()
        {
            Instance.Close();
        }

        public static void GoTo(string url)
        {
            Instance.Url = url;
        }

        public static string Title
        {
            get { return Instance.Title; }

        }
    }
}
