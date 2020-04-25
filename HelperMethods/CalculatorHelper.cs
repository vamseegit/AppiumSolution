using AppiumSolution.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSolution.HelperMethods
{
    public class CalculatorHelper : CalculatorPage
    {
        public string GetSumOfTwoNumbers()
        {
            ClickNumberEight();
            ClickNumberThree();
            ClickAddButton();
            ClickNumberOne();
            ClickEqualButton();
            return GetResult();
        }
    }
}
