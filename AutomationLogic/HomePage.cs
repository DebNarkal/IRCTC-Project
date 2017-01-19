using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationLogic
{
    public class HomePage
    {
        [FindsBy(How = How.Name, Using = "jpform:fromStation")]
        private IWebElement fromStation;
        [FindsBy(How = How.Id, Using = "jpform:toStation")]
        private IWebElement toStation;
        [FindsBy(How = How.Id, Using = "jpform:journeyDateInputDate")]
        private IWebElement dateOfJourney;
        [FindsBy(How = How.Id, Using = "jpform:jpsubmit")]
        private IWebElement submitBtn;

        public void planJourney()
        {
            WaitDriver.wait.Until(ExpectedConditions.ElementExists(By.Id("jpform:journeyDateInputDate")));
            fromStation.SendKeys(JourneyDets.fromStn);
            toStation.SendKeys(JourneyDets.toStn);
            dateOfJourney.SendKeys(JourneyDets.doj);
            submitBtn.Click();
        }

    }
}
