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

        public bool CheckCont()
        {
            MainPage mainPage = new MainPage(driver);
            return mainPage.CheckCont();
        }

        public bool CheckDown()
        {
            DealPage mainPage = new DealPage(driver);
            return mainPage.CheckDown();
        }

        public bool CheckDominik()
        {
            Cont mainPage = new Cont(driver);
            return mainPage.CheckDominik();
        }

        public bool CheckDownload()
        {
            MainPage mainPage = new MainPage(driver);
            return mainPage.CheckDownload();
        }

        public bool CheckStars()
        {
            MainPage mainPage = new MainPage(driver);
            return mainPage.CheckStars();
        }

        public bool CheckMainNews()
        {
            MainPage mainPage = new MainPage(driver);
            return mainPage.CheckMainNews();
        }

        public bool CheckCountryTours()
        {
            MainPage mainPage = new MainPage(driver);
            return mainPage.CheckCountryTours();
        }

        public bool CheckReturnToMain()
        {
            MainPage mainPage = new MainPage(driver);
            return mainPage.CheckReturnToMain();
        }

        public bool CheckReturn()
        {
            CountryPage mainPage = new CountryPage(driver);
            return mainPage.CheckReturn();
        }

        public bool CheckViews()
        {
            MainPage mainPage = new MainPage(driver);
            return mainPage.CheckViews();
        }

        public bool CheckKurs()
        {
            MainPage mainPage = new MainPage(driver);
            return mainPage.CheckKurs();
        }

        public bool CheckSocial()
        {
            MainPage mainPage = new MainPage(driver);
            return mainPage.CheckSocial();
        }
    }
}
