using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading.Tasks;

namespace AutomationLogic
{
    public class LoginPage
    {
        static string Url = "https://www.irctc.co.in/eticketing/loginHome.jsf";
        [FindsBy(How = How.Id, Using = "usernameId")]
        private IWebElement username;
        [FindsBy(How = How.Name, Using = "j_password")]
        private IWebElement pwd;

        public void Goto()
        {
            Browser.Goto(Url);
        }
        public void fillInDetails(string usrnm, string passwrd)
        {
            username.SendKeys(usrnm);
            pwd.SendKeys(passwrd);
        }

        public void PlanJourney()
        {
            var homePage = new HomePage();
            PageFactory.InitElements(Browser.Driver, homePage);
            homePage.planJourney();
        }
    }
}
