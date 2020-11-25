using ADMCloudTest.Handler;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADMCloudTest.PageObject
{
    public class SelectCompanyPage : BasePage
    {
        // Localizadores
        protected By CompanyButton = By.XPath("//*[@id='1c279aec-ed38-456f-a495-1209d78f8acf']");

        // Constructor
        public SelectCompanyPage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Acciones
        public void ClickCompanyButton()
        {
            Driver.FindElement(CompanyButton).Click();
        }

        public HomePage SelectCompanyForLogin()
        {
            WaitHandler.ElementIsPresent(Driver, CompanyButton, 15);
            ClickCompanyButton();
            return new HomePage(Driver);
        }

    }
}
