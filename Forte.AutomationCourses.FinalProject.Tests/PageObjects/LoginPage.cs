using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Forte.AutomationCourses.FinalProject.Tests.PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://phptravels.org/clientarea.php");
        }

        public void LogIn(string email, string password)
        {
            driver.FindElement(By.Id("inputEmail")).SendKeys(email);
            driver.FindElement(By.Id("inputPassword")).SendKeys(password);
            driver.FindElement(By.Id("login")).Submit();
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }
    }
}
