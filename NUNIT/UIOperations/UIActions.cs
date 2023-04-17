using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUNIT.UIOperations
{
   public class UIActions:GlobalVariables
    {

        public UIActions EnterText(IWebElement element,string textToEnter)
        {
            element.SendKeys(textToEnter);
            return new UIActions();
        }

        public UIActions ClickOn(IWebElement element)
        {
            element.Click();
            return new UIActions();
        }
    }
}
