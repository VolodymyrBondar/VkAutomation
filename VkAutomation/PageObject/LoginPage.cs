using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace VkAutomation
{
    public class LoginPage
    {
        private static string url = "http://vk.com";
        [FindsBy(How = How.Id, Using = "quick_email")]
        private IWebElement emailField;

        [FindsBy(How = How.Id, Using = "quick_pass")]
        private IWebElement passwordField;

        [FindsBy(How = How.Id, Using = "quick_login_button")]
        private IWebElement loginButton;

        public void GoTo()
        {
            Driver.Instance.Url = url;
        }

        public void Login(string email, string password)
        {
            emailField.SendKeys(email);
            passwordField.SendKeys(password);
            loginButton.Click();
        }
    }
}
