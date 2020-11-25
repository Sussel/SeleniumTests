using ADMCloudTest.Handler;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADMCloudTest.PageObject
{
    public class LoginPage : BasePage
    {
        // Localizadores
        protected By MailInput = By.Id("txtEMail");
        protected By PasswordInput = By.Id("txtPassword");
        protected By SubmitButton = By.Id("btnSubmit");

        // Constructor
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
            if (!Driver.Title.Equals("Adm Cloud - Login"))
            {
                throw new Exception("This is not the login page");
            }
        }

        // Actiones
        public void TypeMail(string mail)
        {
            Driver.FindElement(MailInput).SendKeys(mail);
        }

        public void TypePassword(string password)
        {
            Driver.FindElement(PasswordInput).SendKeys(password);
        }

        public void ClickSubmitButton()
        {
            Driver.FindElement(SubmitButton).Click();
        }

        // Metodo que devuelva el proceso del login
        public SelectCompanyPage LoginAs(string mail, string password)
        {
            WaitHandler.ElementIsPresent(Driver, MailInput, 15);
            TypeMail(mail);
            WaitHandler.ElementIsPresent(Driver, PasswordInput, 15);
            TypePassword(password);
            WaitHandler.ElementIsPresent(Driver, SubmitButton, 15);
            ClickSubmitButton();

            return new SelectCompanyPage(Driver);
        }
    }
}
