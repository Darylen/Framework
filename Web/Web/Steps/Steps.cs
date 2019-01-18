using Web.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Steps
{
    class Steps
    {
        private IWebDriver driver;

        public void InitBrowser()
        {
            driver = WebDriver.WebDriver.GetInstance();
        }

        public void CloseBrowser()
        {
            WebDriver.WebDriver.CloseBrowser();
        }

        public bool CheckLanguage()
        {
            MainPage mainPage = new MainPage(driver);
            return mainPage.CheckLanguage();
        }

        public bool CheckNamber()
        {
            MainPage mainPage = new MainPage(driver);
            return mainPage.ChekNamber();
        }

        public string CheckStars()
        {
            MainPage mainPage = new MainPage(driver);
            return mainPage.CheckStars();
        }

       
        

        public bool CheckPrace()
        {
            MainPage mainPage = new MainPage(driver);
            int x = mainPage.CheckPrace();
            mainPage.INSPrice();
            int y = mainPage.CheckPrace();
            int z = x * 66;
            if (z == y) return true;
            else return false;
        }

        public bool CheckPep()
        {
            MainPage mainPage = new MainPage(driver);
            string v = mainPage.CheckKolPeple();
            mainPage.Peple();
            string b = mainPage.CheckKolPeple();
            if (v == b) return true;
            else return false;
        }

        public string CheckAll()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.Peple();
            return mainPage.CheckStars();
        }
    }
}
