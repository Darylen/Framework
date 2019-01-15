using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Web.Pages
{
    class MainPage
    {
        private const string PAGE_URL = "https://www.anextour.com/";
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[2]/div/div/div/div[2]/div/ul[1]/li[3]/a")]
        private IWebElement News;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[2]/div/div/div/div[2]/div/ul[1]/li[3]/ul/li[1]/a")]
        private IWebElement MainNews;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[2]/div/div/div/div[2]/div/ul[2]/li[1]/a/span")]
        private IWebElement regionRef;

        [FindsBy(How = How.XPath, Using = "//*[@id='regionModal']/div/div/div[2]/div[1]/div/a")]
        private IWebElement region;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[2]/div/div/div/div[2]/div/ul[1]/li[1]/a")]
        private IWebElement TouristRef;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[2]/div/div/div/div[2]/div/ul[1]/li[1]/ul/li[9]/a")]
        private IWebElement deal;

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[2]/div[2]/div/div[1]/div/div/div/div/div/div/div/p[4]/a")]
        private IWebElement downdeal;

        [FindsBy(How = How.XPath, Using = "//*[@id='mini-search']/nav/div/div/div[6]/div/button")]
        private IWebElement stardrop;

        [FindsBy(How = How.XPath, Using = "//*[@id='mini-search']/nav/div/div/div[6]/div/div/ul/li[2]/a/span[1]")]
        private IWebElement starboxbrop;

        [FindsBy(How = How.XPath, Using = "//*[@id='mini-search']/nav/div/div/div[9]/a")]
        private IWebElement starseach;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[2]/div/div/div/div[2]/div/ul[1]/li[2]/a")]
        private IWebElement AboutCompany;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[2]/div/div/div/div[2]/div/ul[1]/li[2]/ul/li[3]/a")]
        private IWebElement Contacts;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[2]/div/div/div/div[2]/div/ul[1]/li[4]/a")]
        private IWebElement Country;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[2]/div/div/div/div[2]/div/ul[1]/li[4]/ul/li[30]/a/span[2]")]
        private IWebElement CountryT;

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[1]/div/div[1]/div/div[16]/a/img")]
        private IWebElement View;

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[1]/div/div[2]/div[2]/i")]
        private IWebElement NextView;
  
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[1]/div/div/div[2]/a/span[2]")]
        private IWebElement Kurs;
        //*[@id="attentionTop"]/div/div/div/div/span/a

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div[1]/div/div[3]/a[1]")]
        private IWebElement FaceBook;

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div[1]/div/div[3]/a[2]")]
        private IWebElement VK;

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div[1]/div/div[3]/a[3]")]
        private IWebElement OK;

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div[1]/div/div[3]/a[4]")]
        private IWebElement IG;

        [FindsBy(How = How.XPath, Using = "//*[@id='attentionTop']/div/div/div/div/span/a")]
        private IWebElement closecooki;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public bool CheckDownload()
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            Thread.Sleep(3000);
            closecooki.Click();
            Thread.Sleep(1000);
            TouristRef.Click();
            Thread.Sleep(5000);
           // deal.Click();
            driver.Navigate().GoToUrl("https://www.anextour.com/page/dogovor-publichnoy-oferty");
            DealPage d = new DealPage(driver);
            d.CheckDown();
            return true;
        }

        public bool CheckCont()
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            Thread.Sleep(3000);
            closecooki.Click();
            Thread.Sleep(1000);
            AboutCompany.Click();
            Thread.Sleep(5000);
            Contacts.Click();
            driver.Navigate().GoToUrl("https://www.anextour.com/page/kontaktnaya-informatsiya");
            Cont d = new Cont(driver);
            d.CheckDominik();
            return true;
        }

        public bool CheckLanguage()
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            Thread.Sleep(3000);

           // var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
           //var result = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div[2]/div/div/div/div[2]/div/ul[2]/li[1]/a/span")));
           // if (result == null)
           // {
           //     return false;
           // }
            regionRef.Click();
            Thread.Sleep(1000);
            region.Click();
            return true;
        }

        public bool CheckStars()
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            Thread.Sleep(3000);
            closecooki.Click();
            Thread.Sleep(1000);
            stardrop.Click();
            Thread.Sleep(1000);
            starboxbrop.Click();
            Thread.Sleep(1000);
            starseach.Click();
            return true;
        }

        public bool CheckMainNews()
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            Thread.Sleep(3000);
            closecooki.Click();
            Thread.Sleep(1000);
            News.Click();
            Thread.Sleep(1000);
            MainNews.Click();
            return true;
        }

        public bool CheckCountryTours()
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            Thread.Sleep(3000);
            closecooki.Click();
            Thread.Sleep(1000);
            Country.Click();
            Thread.Sleep(1000);
            CountryT.Click();
            driver.Navigate().GoToUrl("https://www.anextour.com/portugal");
            CountryPage d = new CountryPage(driver);
            d.CheckCStars();
            return true;
        }

        public bool CheckReturnToMain()
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            Thread.Sleep(3000);
            closecooki.Click();
            Thread.Sleep(1000);
            Country.Click();
            Thread.Sleep(1000);
            CountryT.Click();
            driver.Navigate().GoToUrl("https://www.anextour.com/portugal");
            CountryPage d = new CountryPage(driver);
            d.CheckReturn();
            Thread.Sleep(3000);
            return true;
        }

        public bool CheckViews()
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            Thread.Sleep(3000);
            closecooki.Click();
            Thread.Sleep(1000);
            NextView.Click();
            Thread.Sleep(1000);
            View.Click();
            return true;
        }

        public bool CheckKurs()
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            Thread.Sleep(3000);
            closecooki.Click();
            Thread.Sleep(1000);
            Kurs.Click();
            Thread.Sleep(1000);
            return true;
        }

        public bool CheckSocial()
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            Thread.Sleep(3000);
            closecooki.Click();
            Thread.Sleep(1000);
            FaceBook.Click();
            OK.Click();
            VK.Click();
            IG.Click();
            Thread.Sleep(1000);
            return true;
        }

        private void ScrollBy(int by)
        {
            IJavaScriptExecutor exe = driver as IJavaScriptExecutor;
            var js = String.Format("window.scrollBy(0, {0});", by);
            exe.ExecuteScript(js);
        }
    }
}
