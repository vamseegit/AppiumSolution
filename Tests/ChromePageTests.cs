using AppiumSolution.BaseClasses;
using AppiumSolution.HelperMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSolution.Tests
{
    [TestClass]
    public class ChromePageTests : BaseClass
    {
        ChromeSearchHelper chromeSearchHelper;
        [TestInitialize]
        public void TestInitialize()
        {
            Init("MobileWeb","Android");
            chromeSearchHelper = new ChromeSearchHelper();
        }

        [TestMethod]
        public void ValidateGoogleSearchOnChromeBrowser()
        {
            _driver.Url = "https://www.bing.com";
            chromeSearchHelper.SearchTextAndEnter();
        }
    }
}
