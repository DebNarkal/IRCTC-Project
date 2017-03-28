using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationLogic
{
    public class PassengerDetails
    {

        public static void fillDetails(DataTable dataGridViewPassengerDetails, DataTable ChildDetails, string boardingPoint, string phoneNo)
        {
            WaitDriver.wait.Until(ExpectedConditions.ElementExists(By.ClassName("psgn-name")));
            var passengerDetailNames = Browser.Driver.FindElements(By.ClassName("psgn-name"));
            var passengerDetailAges = Browser.Driver.FindElements(By.ClassName("psgn-age"));
            var passengerDetailGender = Browser.Driver.FindElements(By.ClassName("psgn-gender"));
            var passengerBerthChoice = Browser.Driver.FindElements(By.ClassName("psgn-berth-choice"));
            var passengerSeniorCitizen = Browser.Driver.FindElements(By.ClassName("psgn-concopt"));
            
            if (!string.IsNullOrEmpty(boardingPoint))
            {
                Browser.Driver.FindElement(By.Id("addPassengerForm:boardingStation")).SendKeys(boardingPoint.Trim());
            }
            int i = 0;
            foreach(DataRow row in dataGridViewPassengerDetails.Rows)
            {
                passengerDetailNames[i].SendKeys(row[1].ToString());
                passengerDetailAges[i].SendKeys(row[2].ToString());
                passengerDetailGender[i].SendKeys(row[3].ToString());
                passengerBerthChoice[i].SendKeys(row[4].ToString());
                if (row[5].ToString()=="True")
                {
                    passengerSeniorCitizen[i].Click();
                }
                i++;
            }
            if(ChildDetails != null)
            {
                int j = 0;
                foreach(DataRow row in ChildDetails.Rows)
                {
                    Browser.Driver.FindElement(By.Id("addPassengerForm:childInfoTable:"+j+":infantName")).SendKeys(row[1].ToString());
                    Browser.Driver.FindElement(By.Id("addPassengerForm:childInfoTable:"+j+":infantAge")).SendKeys(row[2].ToString());
                    Browser.Driver.FindElement(By.Id("addPassengerForm:childInfoTable:" + j + ":infantGender")).SendKeys(row[3].ToString());
                }
            }
            if(!string.IsNullOrEmpty(phoneNo))
            {
                var elemPhoneNo = Browser.Driver.FindElement(By.Id("addPassengerForm:mobileNo"));
                elemPhoneNo.Clear();
                elemPhoneNo.SendKeys(phoneNo);
            }
        }
    }
}
