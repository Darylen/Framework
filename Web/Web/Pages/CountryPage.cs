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
    class CountryPage
    {
        
             
        private const string PAGE_URL = "https://www.anextour.com/portugal";
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@id='attentionTop']/div/div/div/div/span/a")]
        private IWebElement closecooki;

        [FindsBy(How = How.XPath, Using = "//*[@id='hotellist']/div/div/div[2]/div[3]/div/button")]
        private IWebElement stardrop;

        [FindsBy(How = How.XPath, Using = "//*[@id='hotellist']/div/div/div[2]/div[3]/div/div/ul/li[2]/a/span[1]")]
        private IWebElement starboxbrop;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[2]/div/div/div/div[1]/a/img")]
        private IWebElement mainpgs;

        public CountryPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public bool CheckReturn()
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            Thread.Sleep(3000);
           // closecooki.Click();
            Thread.Sleep(1000);
            mainpgs.Click();
            return true;
        }

        public bool CheckCStars()
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            Thread.Sleep(3000);
           // closecooki.Click();
            Thread.Sleep(3000);
            ScrollBy(-600);
            Thread.Sleep(5000);
            stardrop.Click();
            Thread.Sleep(5000);
            starboxbrop.Click();
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
