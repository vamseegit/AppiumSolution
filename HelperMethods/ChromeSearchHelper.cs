using AppiumSolution.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSolution.HelperMethods
{
    public class ChromeSearchHelper : ChromeSearchPage
    {
        public void SearchTextAndEnter()
        {
            //SearchText();
            pageDriver.FindElement(By.Id("sb_form_q")).SendKeys("Hello");
        }
    }
}
