using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace VkAutomation
{
    public class MusicPage
    {

        [FindsBy(How = How.Id, Using = "s_search")]
        private IWebElement searchField;

        [FindsBy(How = How.CssSelector, Using = ".audio_add")]
        private IList<IWebElement> addMusicList;

        [FindsBy(How = How.Id, Using = "audios_albums")]
        private IWebElement audioAlbums;

        [FindsBy(How = How.Id, Using = "album_add")]
        private IWebElement addAudioAlbum;

        [FindsBy(How = How.Id, Using = "album_name")]
        private IWebElement albumNameField;

        [FindsBy(How = How.CssSelector, Using = ".text.olist_filter")]
        private IWebElement searchMusicForAlbumField;

        [FindsBy(How = How.CssSelector, Using = ".olist_item.clear_fix")]
        private IList<IWebElement> searchMusicList;

        [FindsBy(How = How.ClassName, Using = "flat_button")]
        private IWebElement saveButton;

        [FindsBy(How = How.XPath, Using = ".//*[@id='audio_albums_wrap']")]
        private IList<IWebElement> createdAlbums;

        public ArrayList ListOfUserAlbums()
        {
            ArrayList listOfUserAlbums = new ArrayList();
            for (int i = 0; i < createdAlbums.Count; i++)
            {
                listOfUserAlbums.Add(createdAlbums[i].Text);
                Console.WriteLine(listOfUserAlbums[i]);
            }
            return listOfUserAlbums;
        }

        public void SearchMusic(string music)
        {
            searchField.SendKeys(music);
        }

        public void GoToMyAlbums()
        {
            audioAlbums.Click();
        }

        public void CreateNewAlbum(string albumName)
        {
            addAudioAlbum.Click();
            albumNameField.SendKeys(albumName);
        }

        public void SearchMusicForAlbum(string music)
        {
            searchMusicForAlbumField.SendKeys(music);
        }
        public void AddMusicForAlbumByArtistName(string artistName)
        {
            string s;
            for (int i = 0; i < searchMusicList.Count; i++)
            {
                s = searchMusicList[i].Text.Substring(0, searchMusicList[i].Text.IndexOf("–"));
                if (s.Contains(artistName))
                {
                    searchMusicList[i].Click();
                }   
            }
            saveButton.Click();
        }
        public void AddMusicForAlbumBySongName(string songName)
        {
            string s;
            for (int i = 0; i < searchMusicList.Count; i++)
            {
                s = searchMusicList[i].Text.Substring(searchMusicList[i].Text.IndexOf("–"));
                if (s.Contains(songName))
                {
                    searchMusicList[i].Click();
                }
            }
            saveButton.Click();
        }
        public bool ContainsCreatedAlbum(string music)
        {
            bool result = false;
            foreach (var album in createdAlbums)
            {
                result = album.Text.Contains(music);
                if (result == true)
                {
                    break;
                }
            }
            return result;
        }

        //TODO Not implemented
        public void AddMusic()
        {
            Console.WriteLine("Count is: " + addMusicList.Count);
            for (int i = 0; i < addMusicList.Count; i++)
            {
                Console.WriteLine("Number is " + i);
                Actions builder = new Actions(Driver.Instance);
                Actions hoverClick = new Actions(Driver.Instance);
                var add = addMusicList[i];
                hoverClick = builder.MoveToElement(add).Click();
                hoverClick.Build().Perform();
                //                ((IJavaScriptExecutor)Driver.Instance).ExecuteScript("arguments[0].hidden = false;", addMusicList[i]);
                //                addMusicList[i].Click();
                //                ((IJavaScriptExecutor)Driver.Instance).ExecuteScript("arguments[0].hidden = true;", addMusicList[i]);
            }
        }


       
    }
}
