using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUNIT.Utilities.common
{
    class Common:GlobalVariables
    {
        public Common LaunchBrowser(string browserType)
        {
            try
            {
                switch (browserType.ToUpper())
                {
                    case "CHROME":
                        driver = new ChromeDriver();
                        driver.Manage().Window.Maximize();
                        break;
                    default:
                        break;
                }
            }
            catch(Exception e)
            {

            }
            return new Common(); 
        }

        public void NavigateTo(string URL)
        {
            try
            {
                driver.Navigate().GoToUrl(URL);
            }
            catch(Exception e)
            {

            }
        }

        public void CloseProcess(string ProcessName)
        {
            try
            {
               foreach(var process in Process.GetProcessesByName(ProcessName))
                {
                    process.Kill();
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
