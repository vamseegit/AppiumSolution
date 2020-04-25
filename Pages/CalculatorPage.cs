using AppiumSolution.BaseClasses;
using AppiumSolution.HelperClasses;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSolution.Pages
{
   public class CalculatorPage : PageActions
    {
        public void ClickNumberEight()
        {
            ClickElement(By.Id("digit_8"));
        }

        public void ClickNumberThree()
        {
            ClickElement(By.Id("digit_3"));
        }

        public void ClickNumberOne()
        {
            ClickElement(By.Id("digit_1"));
        }

        public void ClickAddButton()
        {
            ClickElement(By.Id("op_add"));
        }

        public void ClickEqualButton()
        {
            ClickElement(By.Id("eq"));
        }

        public string GetResult()
        {
           return GetElement(By.Id("result")).Text.ToString();
        }
    }
}
