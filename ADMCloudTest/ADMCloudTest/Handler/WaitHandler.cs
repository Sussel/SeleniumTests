using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADMCloudTest.Handler
{
    public class WaitHandler
    {
        public static bool ElementIsPresent(IWebDriver driver, By locator, int time)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(drv => drv.FindElement(locator));
                return true;
            }
            catch { }

            return false;
        }

    }
}
