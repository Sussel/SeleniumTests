using ADMCloudTest.PageObject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADMCloudTest.TestCases
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        private SelectCompanyPage sCompanyPage;

        [SetUp]
        public void BeforeTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            sCompanyPage = loginPage.LoginAs("sm.villarroel@gmail.com", "s45YkBg3es45");
        }

        [Test]
        public void SuccesfullLoginTest()
        {
            HomePage homePage = sCompanyPage.SelectCompanyForLogin();
            Assert.IsTrue(homePage.MainNavBarIsPresent());
        }
        
    }
}
