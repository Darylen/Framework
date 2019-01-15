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
    class Cont
    {
        
        private const string PAGE_URL = "https://www.anextour.com/page/kontaktnaya-informatsiya";
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[2]/div[2]/div/div[1]/div/div/div/div/div/div/div/div/ul/li[10]/h4/a")]
        private IWebElement dominik;

        public Cont(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public bool CheckDominik()
        {
            driver.Navigate().GoToUrl(PAGE_URL);
            Thread.Sleep(3000);
            ScrollBy(-600);
            dominik.Click();
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
