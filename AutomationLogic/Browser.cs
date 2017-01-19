using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace AutomationLogic
{
    public static class Browser
    {
        static IWebDriver webDriver = new FirefoxDriver();

        public static ISearchContext Driver
        {
            get
            {
                return webDriver;
            }
        }

        public static void Goto(string url)
        {
            webDriver.Url = url;
            //webDriver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromMinutes(5));
            WaitDriver.wait = wait;
        }
    }

    
}
