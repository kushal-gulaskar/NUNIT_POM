using NUnit.Framework;
using NUNIT.Pages;
using NUNIT.Utilities.hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
