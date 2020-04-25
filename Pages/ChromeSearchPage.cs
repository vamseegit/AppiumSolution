using AppiumSolution.HelperClasses;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSolution.Pages
{
    public class ChromeSearchPage : PageActions
    {
        public void SearchText()
        {
            SendTextToElement(By.ClassName("android.widget.EditText"), "Hello World");
        }
    }
}
