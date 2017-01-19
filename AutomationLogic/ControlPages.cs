using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationLogic
{
    public static class ControlPages
    {
        public static LoginPage loginPage
        {
            get
            {
                var logPage = new LoginPage();
                PageFactory.InitElements(Browser.Driver, logPage);
                return logPage;
            }
        }
    }
}
