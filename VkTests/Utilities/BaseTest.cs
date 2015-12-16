using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VkAutomation;

namespace VkTests
{
    [TestClass]
    public class BaseTest
    {
        [TestInitialize]
        public void Initialize()
        {
            Driver.Initialize();
            Pages.LoginPage.GoTo();
            Pages.LoginPage.Login("someemail@gmail.com", "somepassword");
        }

        [TestCleanup]
        public void TearDown()
        {
            Driver.Close();
        }
    }
}
