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
        [FindsBy(How = How.LinkText, Using = "Мои Аудиозаписи")]
        private IWebElement myMusicButton;

        public void GoToMusic()
        {
            myMusicButton.Click();
        }

        public bool IsAt()
        {
            return myMusicButton.Displayed;          
        }
    }
}
