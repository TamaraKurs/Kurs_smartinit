using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1
{
    class LoginPage
    {
        IWebDriver driver = new ChromeDriver();
        
        [Test]
        public void Login()
        {
            driver.Navigate().GoToUrl("https://elearn.smartinit.net/login/index.php");
            driver.Manage().Window.Maximize();

        }
    }
}
