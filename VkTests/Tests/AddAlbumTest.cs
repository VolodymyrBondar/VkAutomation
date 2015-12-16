using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VkAutomation;

namespace VkTests
{
    [TestClass]
    public class AddAlbumTest : BaseTest
    {
        [TestMethod]
        public void AddingAlbumTest()
        {
            Pages.HomePage.GoToMusic();
            Pages.MusicPage.GoToMyAlbums();
            Pages.MusicPage.CreateNewAlbum("Louis Armstrong");
            Pages.MusicPage.SearchMusicForAlbum("Louis Armstrong");
            Pages.MusicPage.AddMusicForAlbum();
            Assert.IsTrue(Pages.MusicPage.ContainsCreatedAlbum("Louis Armstrong"));
        }
    }
}
          