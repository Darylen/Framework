﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.WebDriver
{
    public class WebDriver
    {
        private static IWebDriver driver;

        private WebDriver() { }

        public static IWebDriver GetInstance()
        {
            if (driver == null)
            {
                var dir = "C:\\Users\\Darylen\\source\\repos\\Web\\Web\\Utils";
                driver = new ChromeDriver(System.IO.Path.GetFullPath(dir));
                //driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
               // driver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromSeconds(30));
            }

            return driver;
        }

        public static void CloseBrowser()
        {
            driver.Close();
            driver = null;
        }
    }
}