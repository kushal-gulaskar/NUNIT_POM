using NUnit.Framework;
using NUNIT.Pages;
using NUNIT.Utilities.hooks;

namespace NUNIT.Tests
{

    class LoginOrangeHrm:TestListner
    {
        LoginOrangeHRMPage loginpage = new LoginOrangeHRMPage();

        [Test]
        public void LoginTest()
        {
            loginpage.LoginOrangeHRM();
        }

        [Test]
        public void LoginTest2()
        {
            loginpage.LoginOrangeHRM();
        }
    }
}
