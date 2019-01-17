using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Web.Tests
{
    [TestFixture]
    class Tests
    {
        private Steps.Steps steps = new Steps.Steps();

        [SetUp]
        public void SetUp()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void CleanUp()
        {
            steps.CloseBrowser();
        }

        [Test] //Test #1
        public void CheckLanguage()
        {
            //driver.Navigate().GoToUrl("https://www.anextour.com/");
            //Thread.Sleep(5000);

            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/div/div[2]/div/ul[2]/li[1]/a/span")).Click();
            //Thread.Sleep(2000);
            //driver.FindElement(By.XPath("//*[@id='regionModal']/div/div/div[2]/div[1]/div/a")).Click();
            //driver.Close();


            Assert.AreEqual(steps.CheckLanguage(), true);
        }

        [Test] //Test #2
        public void CheckDownload()
        {
            Assert.AreEqual(steps.CheckDownload(), true);
        }

        [Test] //Test #3
        public void CheckStars()
        {
            Assert.AreEqual(steps.CheckStars(), true);
        }

        [Test] //Test #4
        public void CheckCont()
        {
            Assert.AreEqual(steps.CheckCont(), true);
        }

        [Test] //Test #5
        public void CheckMainNews()
        {
            Assert.AreEqual(steps.CheckMainNews(), true);
        }

        [Test] //Test #6
        public void CheckContryTours()
        {
            Assert.AreEqual(steps.CheckCountryTours(), true);
        }

        [Test] //Test #7
        public void CheckReturnToMain()
        {
            Assert.AreEqual(steps.CheckReturnToMain(), true);
        }

        //[Test] //Test #8
        //public void CheckViews()
        //{
        //    Assert.AreEqual(steps.CheckViews(), true);
        //}

        [Test] //Test #9
        public void CheckKurs()
        {
            Assert.AreEqual(steps.CheckKurs(), true);
        }

        [Test] //Test #10
        public void CheckSocial()
        {
            Assert.AreEqual(steps.CheckSocial(), true);
        }
    }
}
