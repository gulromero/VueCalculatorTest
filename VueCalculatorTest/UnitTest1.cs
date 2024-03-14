using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.CompilerServices;


namespace VueCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {

        //Providing the path to the ChromeDriver on my pc
        private static readonly string DriverDirectory = "C:\\Driver";
        private static IWebDriver _driver;


        [ClassInitialize]
        //Setting up the ChromeDriver
        public static void Setup(TestContext context)
        {
            _driver = new ChromeDriver(DriverDirectory);
        }

        [ClassCleanup] 

        //Closing the ChromeDriver
        public static void TearDown()
        {
            _driver.Dispose();
        }


        [TestMethod]
        public void TestMethod1()
        {

            //Navigating to the VueCalculator website
            _driver.Navigate().GoToUrl("https://vuecalcgulsum.azurewebsites.net/");

            //Testing the title of the website
            Assert.AreEqual("Gülsüm's genius calculator", _driver.Title);

            //Testing the input1 
            IWebElement input1 = _driver.FindElement(By.Id("input1Id"));
            input1.SendKeys("1");

            //Testing the input2
            IWebElement input2 = _driver.FindElement(By.Id("input2Id"));
            input2.SendKeys("2");

            //Testing the select
            IWebElement select = _driver.FindElement(By.Id("selectId"));
            select.SendKeys("+");
 
        }
    }
}