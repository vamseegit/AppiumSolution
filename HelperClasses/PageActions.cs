using AppiumSolution.BaseClasses;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSolution.HelperClasses
{
    public class PageActions : BaseClass
    {
        public AppiumDriver<AppiumWebElement> pageDriver;

        public PageActions()
        {
            pageDriver = BaseClass.AppDriver;
        }

        public void ClickElement(By selector)
        {
            pageDriver.FindElement(selector).Click();
        }

        public AppiumWebElement GetElement(By selector)
        {
            return pageDriver.FindElement(selector);
        }

        public void SendTextToElement(By selector, string text)
        {
            //pageDriver.FindElement(selector).SendKeys(text);
        }
    }
}
