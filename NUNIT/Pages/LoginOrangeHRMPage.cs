using NUNIT.UIOperations;
using OpenQA.Selenium;

namespace NUNIT.Pages
{
    class LoginOrangeHRMPage:UIActions
    {
        public static IWebElement uname => driver.FindElement(By.Name("username"));
        public static IWebElement LoginButton => driver.FindElement(By.XPath("//*[@id='app']/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button"));

        public LoginOrangeHRMPage LoginOrangeHRM()
        {
            EnterText(uname, "Admin");
            ClickOn(LoginButton);

            return new LoginOrangeHRMPage();
        }

    }
}
