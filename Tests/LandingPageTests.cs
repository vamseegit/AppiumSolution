using System;
using AppiumSolution.BaseClasses;
using AppiumSolution.HelperMethods;
using AppiumSolution.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Remote;

namespace AppiumSolution
{
    [TestClass]
    public class LandingPageTests : BaseClass
    {
        CalculatorHelper calculatorHelper;

        [TestInitialize]
        public void TestInitialize()
        {
            Init("MobileApp", "Android");
            calculatorHelper = new CalculatorHelper();
        }

        [TestMethod]
        public void ValidateCalculatorAppiumOptions()
        {
            var sum = calculatorHelper.GetSumOfTwoNumbers();

            Assert.IsNotNull(AppDriver.Context);
            Assert.AreEqual("84", sum, "Sum is not as expected");

        }
    }
}
