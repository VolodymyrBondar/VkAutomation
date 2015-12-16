using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace VkAutomation
{
    public class HomePage
    {
        [FindsBy(How = How.XPath, Using = ".//*[@id='side_bar']/ol/li[5]/a/span/span[2]")]
        private IWebElement myMusicButton;

        public void GoToMusic()
        {
            myMusicButton.Click();
        }
    }
}
