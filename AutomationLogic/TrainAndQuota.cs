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
                Browser.Driver.FindElement(By.XPath(String.Format("//td[text()='{0}']", quota))).FindElement(By.TagName("input")).Click();
                driver.SwitchTo().Alert().Accept();
            }
            catch (NoAlertPresentException ex)
            {

            }
            string quotaAvvr = getBookNowText(quota);
            Browser.Driver.FindElement(By.XPath(string.Format("//td/a[contains(text(),'{0}')]/ancestor::tr/td[16]/a[contains(text(),'{1}')]", trainNo, journeyClass))).Click();
            string bookNowId = trainNo + "-" + journeyClass + "-" + quotaAvvr + "-0";
            WaitDriver.wait.Until(ExpectedConditions.ElementExists(By.Id(bookNowId.Trim())));
            var bookNowElement = driver.FindElement(By.Id(bookNowId));
            IJavaScriptExecutor exec = driver as IJavaScriptExecutor;
            exec.ExecuteScript("arguments[0].click();", bookNowElement);
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
                case "Tatkal":
                    return "CK";
                default:
                    return "GN";
            }
        }
    }
}
