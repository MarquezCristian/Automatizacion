using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Facebook_Automation_Program
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
        }
        [SetUp]
        public void Inicializar()
        {
            driver.Navigate().GoToUrl("https://www.facebook.com");
        }

        [Test]
        public void EjecutarPrueba()
        {
            driver.Manage().Window.Maximize();

            IWebElement firstName = driver.FindElement(By.Id("u_0_m"));
            firstName.SendKeys("John");
            IWebElement lastName = driver.FindElement(By.Id("u_0_o"));
            lastName.SendKeys("Wick");
            IWebElement email = driver.FindElement(By.Id("u_0_r"));
            email.SendKeys("johndoe12345@gmail.com");
            IWebElement repeatEmail = driver.FindElement(By.Id("u_0_u"));
            repeatEmail.SendKeys("johndoe12345@gmail.com");
            IWebElement password = driver.FindElement(By.Id("u_0_w"));
            password.SendKeys("johnsnow123");
            IWebElement month = driver.FindElement(By.Id("month"));
            var selectElementMonth = new SelectElement(month);
            selectElementMonth.SelectByValue("12");

            IWebElement day = driver.FindElement(By.Id("day"));
            var selectElementDay = new SelectElement(day);
            selectElementDay.SelectByValue("7");

            IWebElement year = driver.FindElement(By.Id("year"));
            var selectElementYear = new SelectElement(year);
            selectElementYear.SelectByValue("2003");

            IWebElement genderButton = driver.FindElement(By.Id("u_0_6"));
            genderButton.Click();

            IWebElement signUpButton = driver.FindElement(By.Id("u_0_13"));
            signUpButton.Click();

            Thread.Sleep(7000);

            IWebElement mensajeConfirmacion = driver.FindElement(By.XPath("//*[@id=\"u_c_d\"]/div/div[3]/div/div/div[1]/div"));
            Assert.That(mensajeConfirmacion.Text.Contains("Necesitamos confirmar tu identidad"));

        }

        [TearDown]
        public void CloseTest()
        {
            
        }


    }
}
