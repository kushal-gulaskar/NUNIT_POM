using NUnit.Framework;
using NUNIT.UIOperations;
using NUNIT.Utilities.common;

namespace NUNIT.Utilities.hooks
{
    [TestFixture]
    class TestListner:UIActions
    {
        [SetUp]
        public void StartTest()
        {
            new Common().LaunchBrowser("CHROME").NavigateTo("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
        }

        [TearDown]
        public void EndTest()
        {
            GlobalVariables.driver.Quit();
        }
    }
}
