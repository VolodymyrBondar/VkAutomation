using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace VkAutomation
{
    public static class Pages
    {
        public static LoginPage LoginPage
        {
            get
            {
                var loginPage = new LoginPage();
                PageFactory.InitElements(Driver.Instance, loginPage);
                return loginPage;
            }

        }
        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                PageFactory.InitElements(Driver.Instance, homePage);
                return homePage;
            }

        }
        public static MusicPage MusicPage
        {
            get
            {
                var musicPage = new MusicPage();
                PageFactory.InitElements(Driver.Instance, musicPage);
                return musicPage;
            }
        }
    }
}
