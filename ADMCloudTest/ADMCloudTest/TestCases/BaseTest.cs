using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADMCloudTest.TestCases
{
    public class BaseTest
    {
        protected IWebDriver Driver;
        protected string Url = ConfigurationManager.AppSettings["Url"];

        [SetUp]
        public void BeforeBaseTest()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(Url);
        }

        [TearDown]
        public void AfterBaseTest()
        {
            //if(Driver != null)
                //Driver.Quit();
        }
    }
}
