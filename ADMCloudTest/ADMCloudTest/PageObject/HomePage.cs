using ADMCloudTest.Handler;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADMCloudTest.PageObject
{
    public class HomePage : BasePage
    {
        // Localizadores
        protected By MainNavBar = By.XPath("//*[@class='navbar navbar-default nav-color navbar-fixed-top']");

        // Constructor
        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Acciones
        public bool MainNavBarIsPresent()
        {
            return WaitHandler.ElementIsPresent(Driver, MainNavBar, 200);
        }
    }
}
