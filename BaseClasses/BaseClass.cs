using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSolution.BaseClasses
{
    public class BaseClass
    {
        // Creating an instance of Driver.
        public static AppiumDriver<AppiumWebElement> _driver;

        public static AppiumDriver<AppiumWebElement> AppDriver
        {
            get
            {
                return _driver;
            }
            set
            {
                _driver = value;
            }
        }

        public void Init(string target, string osName)
        {
            if (target == "MobileApp")
            {
                if (osName == "Android")
                {
                    AppiumOptions appiumOptions = new AppiumOptions();
                    //Name of the devices from adb devices
                    appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, ConfigurationManager.AppSettings["DeviceName"]);
                    appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, ConfigurationManager.AppSettings["PlatformName"]);
                    appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, ConfigurationManager.AppSettings["PlatformVersion"]);
                    //App package name from ApkInfo. Opening calculator app
                    appiumOptions.AddAdditionalCapability(AndroidMobileCapabilityType.AppPackage, ConfigurationManager.AppSettings["AppPackage"]);
                    appiumOptions.AddAdditionalCapability(AndroidMobileCapabilityType.AppActivity, ConfigurationManager.AppSettings["AppActivity"]);
                    appiumOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, ConfigurationManager.AppSettings["AutomationName"]);

                    //Host where Appium server is running. Connects to the emulator
                    _driver = new AndroidDriver<AppiumWebElement>(new Uri(ConfigurationManager.AppSettings["UriPath"]), appiumOptions);
                }
                else if (osName == "iOS")
                {

                }
            }
            else if (target == "MobileWeb")
            {
                if (osName == "Android")
                {
                    AppiumOptions appiumOptionsWeb = new AppiumOptions();
                    appiumOptionsWeb.AddAdditionalCapability(MobileCapabilityType.DeviceName, ConfigurationManager.AppSettings["DeviceName"]);
                    appiumOptionsWeb.AddAdditionalCapability(MobileCapabilityType.PlatformName, ConfigurationManager.AppSettings["PlatformName"]);
                    appiumOptionsWeb.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, ConfigurationManager.AppSettings["PlatformVersion"]);
                    appiumOptionsWeb.AddAdditionalCapability(MobileCapabilityType.AutomationName, ConfigurationManager.AppSettings["AutomationName"]);
                    appiumOptionsWeb.AddAdditionalCapability(MobileCapabilityType.NoReset, "true");
                    appiumOptionsWeb.AddAdditionalCapability(MobileCapabilityType.BrowserName, "Chrome");
                    appiumOptionsWeb.AddAdditionalCapability("chromedriverExecutable", (Path.GetFullPath(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName) + "\\chromedriver.exe"));
                    appiumOptionsWeb.AddAdditionalCapability("w3c", false);

                    //ChromeOptions chromeOptions = new ChromeOptions();
                    //chromeOptions.AddAdditionalCapability("w3c", false);

                    //appiumOptionsWeb.AddAdditionalCapability(ChromeOptions.Capability, chromeOptions);


                    //Host where Appium server is running. Connects to the emulator
                    _driver = new AndroidDriver<AppiumWebElement>(new Uri(ConfigurationManager.AppSettings["UriPath"]), appiumOptionsWeb);

                }
                else if (osName == "iOS")
                {

                }
            }
        }
    }
}
