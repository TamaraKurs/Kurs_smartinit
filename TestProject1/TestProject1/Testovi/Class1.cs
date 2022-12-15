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
        #region Testovi
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void Login()
        {
            driver.Navigate().GoToUrl("https://elearn.smartinit.net/login/index.php");
            driver.Manage().Window.Maximize();

            var korisnickoIme = driver.FindElement(By.Id("username"));
            Assert.NotNull(korisnickoIme);

            var lozinka = driver.FindElement(By.Id("password"));
            Assert.NotNull(lozinka);

            var dugme = driver.FindElement(By.Id("loginbtn"));
            Assert.NotNull(dugme);


        }
        [Test]
        public void Login_2()
        {
            driver.Navigate().GoToUrl("https://elearn.smartinit.net/login/index.php");
            driver.Manage().Window.Maximize();


            driver.FindElement(By.Id("username")).SendKeys("nenad.antonic@live.com");

            driver.FindElement(By.Id("password")).SendKeys("klasikaK1-");

            driver.FindElement(By.Id("loginbtn")).Click();

            var stranica = driver.FindElement(By.XPath("//*[contains(text(), 'Moji kursevi')]"));
            Assert.NotNull(stranica);
            

        }
    }
    #endregion
}
