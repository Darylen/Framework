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
        private const string url = "https://www.anextour.com/cyprus/hotel/flora-maria-hotel-cyprus?CHECKIN_BEG=20190127&CHECKIN_END=20190127&HOTEL=15757&NIGHTMIN=7&NIGHTMAX=7&ADULT=2&CHILD=0&AGE1=&AGE2=&AGE3=&TOWNFROM=2&STATE=79&CURRENCY=1&PTYPE=&HOTELTYPES=&COSTMIN=&COSTMAX=&MEALLIST=&INSTANT_CONFIRM=0&SMART_SEARCH=FLORA%20MARIA%20HOTEL";
        private IWebDriver driver;
        WebDriverWait wait;

       
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[2]/div/div/div/div[2]/div/ul[2]/li[1]/a/span")]
        private IWebElement regionRef;

        [FindsBy(How = How.XPath, Using = "//*[@id='regionModal']/div/div/div[2]/div[1]/div/a")]
        private IWebElement region;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[2]/div/div/div/div[2]/div/ul[1]/li[1]/a")]
        private IWebElement TouristRef;

      
        [FindsBy(How = How.XPath, Using = "//*[@id='mini-search']/nav/div/div/div[6]/div/button")]
        private IWebElement stardrop;

        [FindsBy(How = How.XPath, Using = "//*[@id='mini-search']/nav/div/div/div[6]/div/div/ul/li[2]/a/span[1]")]
        private IWebElement starboxbrop;

        [FindsBy(How = How.XPath, Using = "//*[@id='mini-search']/nav/div/div/div[9]/a")]
        private IWebElement starseach;


        [FindsBy(How = How.XPath, Using = "//*[@id='attentionTop']/div/div/div/div/span/a")]
        private IWebElement closecooki;

        //*[@id="hotel-search-panel"]/div/div/div[5]/div[1]/div/div/div[2]/div/div[2]/table/tbody/tr/td[4]/span[2]/span
        [FindsBy(How = How.XPath, Using = "//*[@id='hotel-search-panel']/div/div/div[5]/div[1]/div/div/div[2]/div/div[2]/table/tbody/tr/td[4]/span[2]/span")]
        private IWebElement prace;

        
        [FindsBy(How = How.XPath, Using = "//*[@id='hotel-search-panel']/div/div/div[2]/div[4]/div/div/div[1]/span/span[2]/span")]
        private IWebElement inPrice;

        
        [FindsBy(How = How.XPath, Using = "//*[@id='ui-select-choices-row-16-0']/span/div")]
        private IWebElement RPrice;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[1]/div/div/div[2]/ul/li[10]/a")]
        private IWebElement MNamber;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[2]/div/div/div/div[2]/div/ul[2]/li[2]/a")]
        private IWebElement SecondNamber;

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[2]/div/div/div/div/div[2]/div[1]/div/div/div[2]/div[1]/div[1]/div[1]/a/span[1]")]
        private IWebElement Nme;


        [FindsBy(How = How.XPath, Using = "//*[@id='mini-search']/nav/div/div/div[8]/div/div[1]/input")]
        private IWebElement Npeople;

        [FindsBy(How = How.XPath, Using = "//*[@id='mini-search']/nav/div/div/div[8]/div/div[2]/div[2]/div/div[1]/span/span[2]/span")]
        private IWebElement Chield;

        [FindsBy(How = How.XPath, Using = "//*[@id='ui-select-choices-row-4-3']/span/div")]
        private IWebElement NChield;

        [FindsBy(How = How.XPath, Using = "//*[@id='navbar']/ul[2]/li[2]/a")]
        private IWebElement NameCont;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            PageFactory.InitElements(this.driver, this);
        }

       
        public bool CheckLanguage()
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            wait.Until(ExpectedConditions.ElementToBeClickable(regionRef));
            regionRef.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(region));
            region.Click();
            if (NameCont.Text == "МИНСК")
                return true;
            else return false;
        }

        public string CheckStars()
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            wait.Until(ExpectedConditions.ElementToBeClickable(closecooki));
            closecooki.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(stardrop));
            stardrop.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(starboxbrop));
            starboxbrop.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(starseach));
            starseach.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(Nme));
            return  Nme.Text;
        }

        public int CheckPrace()
        {
            driver.Navigate().GoToUrl(url);
            wait.Until(ExpectedConditions.ElementToBeClickable(closecooki));
            closecooki.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(prace));
            string y = prace.Text;
            int x = Convert.ToInt16(y);
            return x;
        }

        public void INSPrice()
        {
            driver.Navigate().GoToUrl(url);
            wait.Until(ExpectedConditions.ElementToBeClickable(closecooki));
            closecooki.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(inPrice));
            inPrice.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(RPrice));
            RPrice.Click();

        }

            public void ClickPrice()
        {
            driver.Navigate().GoToUrl(url);
            wait.Until(ExpectedConditions.ElementToBeClickable(closecooki));
            closecooki.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(inPrice));
            inPrice.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(RPrice));
            RPrice.Click();
        }

        public bool ChekNamber()
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            wait.Until(ExpectedConditions.ElementToBeClickable(SecondNamber));
            string number = SecondNamber.Text;
            wait.Until(ExpectedConditions.ElementToBeClickable(regionRef));
            regionRef.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(region));
            region.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(MNamber));
            if (number == MNamber.Text)
                return false;
            else return true;
        }

        public string CheckKolPeple()
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            wait.Until(ExpectedConditions.ElementToBeClickable(Npeople));
            return Npeople.Text;
        }

        public void Peple()
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            wait.Until(ExpectedConditions.ElementToBeClickable(Npeople));
            Npeople.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(Chield));
            Chield.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(NChield));
            NChield.Click();
        }
    }
}
