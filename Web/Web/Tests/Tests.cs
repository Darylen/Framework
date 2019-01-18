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
            Assert.AreEqual(steps.CheckLanguage(), true);
        }

        [Test] //Test #2
        public void CheckStars()
        {
            Assert.AreEqual(steps.CheckStars(), "4 * ***");
        }

        [Test] //Test #3
        public void CheckKonvert()
        {
            bool Relust = steps.CheckPrace();

            Assert.AreEqual(Relust, true);
        }

        [Test] //Test #4
        public void CheckNumber()
        {
            bool Relust = steps.CheckNamber();

            Assert.AreEqual(Relust, true);
        }

        [Test] //Test #5
        public void CheckNumberPeople()
        {
            bool Relust = steps.CheckPep();

            Assert.AreEqual(Relust, true);
        }

        [Test] //Test #6
        public void CheckSeach()
        {
            Assert.AreEqual(steps.CheckAll(), "4 * ***");
        }

    }
}
