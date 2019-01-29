using Forte.AutomationCourses.FinalProject.Tests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forte.AutomationCourses.FinalProject.Tests
{
    [TestFixture]
    public class TestSuite001
    {
        [Test]
        public void VerifyErrorMessages()
        {
            var loginPage = new LoginPage();
            loginPage.LogIn("wrong@email.com", "password");

            try
            {
                if (loginPage.GetDriver().FindElement(By.ClassName("alert-danger")).Text != "Login Details Incorrect. Please try again.")
                {
                    throw new Exception("Error");
                }
            }
            catch (StaleElementReferenceException)
            {
                Console.WriteLine("stale element reference exception was caught");
            }
        }
    }
}
