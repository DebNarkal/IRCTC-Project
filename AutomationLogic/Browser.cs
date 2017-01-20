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
using System.IO;

namespace AutomationLogic
{
    public static class Browser
    {

        static IWebDriver webDriver = new FirefoxDriver(initService(), initOptions(), TimeSpan.FromSeconds(10));

        private static FirefoxDriverService initService()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "geckodriver.exe");
            service.HideCommandPromptWindow = true;
            return service;
        }

        private static FirefoxOptions initOptions()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            return options;
        }


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
