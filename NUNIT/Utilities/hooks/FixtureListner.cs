using NUnit.Framework;
using NUNIT.Utilities.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUNIT.Utilities.hooks
{
    [SetUpFixture]
    class FixtureListner
    {

        [OneTimeSetUp]
        public void SetUpEnvironment()
        {
            
        }

        [OneTimeTearDown]
        public void TearDownEnvironment()
        {
            new Common().CloseProcess("chromedriver");
        }
    }

}
