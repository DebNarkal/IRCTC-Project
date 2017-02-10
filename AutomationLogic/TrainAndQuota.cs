using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace AutomationLogic
{
    public class TrainAndQuota
    {
        public static void SelectTrainAndQuota(string quota, string trainNo, string journeyClass)
        {
            WaitDriver.wait.Until(ExpectedConditions.ElementExists(By.TagName("input")));
            IWebDriver driver = (IWebDriver)Browser.Driver;
            try
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));
                WaitDriver.wait.Until(ExpectedConditions.ElementExists(By.XPath(String.Format("//td[text()='{0}']", quota))));
                Browser.Driver.FindElement(By.XPath(String.Format("//td[text()='{0}']", quota))).FindElement(By.TagName("input")).Click();
                driver.SwitchTo().Alert().Accept();
            }
            catch (NoAlertPresentException ex)
            {

            }
            string quotaAvvr = getBookNowText(quota);
            Browser.Driver.FindElement(By.XPath(string.Format("//td/a[contains(text(),'{0}')]/ancestor::tr/td[16]/a[contains(text(),'{1}')]", trainNo, journeyClass))).Click();
            string bookNowId = trainNo + "-" + journeyClass + "-" + quotaAvvr + "-0";
            IJavaScriptExecutor exec = driver as IJavaScriptExecutor;
            try
            {
                WaitDriver.wait.Until(ExpectedConditions.ElementExists(By.Id(bookNowId.Trim())));
                var bookNowElement = driver.FindElement(By.Id(bookNowId));
                exec.ExecuteScript("arguments[0].click();", bookNowElement);
                driver.SwitchTo().Alert().Accept();

            }
            catch (NoAlertPresentException) { }
            catch (NoSuchElementException)
            {
                try
                {
                    exec.ExecuteScript("alert('Booking is not possible')", null);
                    driver.SwitchTo().Alert();
                    Environment.Exit(0);
                }
                catch (Exception) { }
                return;
            }
            
        }

        private static string getBookNowText(string quota)
        {
            switch(quota)
            {
                case "General":
                    return "GN";
                case "Ladies":
                    return "LD";
                case "Premium Tatkal":
                    return "PT";
                case "Physically Handicap":
                    return "HP";
                case "TATKAL":
                    return "TQ";
                default:
                    return "GN";
            }
        }
    }
}
