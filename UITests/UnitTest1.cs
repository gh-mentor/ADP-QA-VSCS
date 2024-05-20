/*
 * This file contains the Selenium WebDriver test methods for the Employee Details page.
 * Details:
 * It uses the Chrome browser to navigate to the Employee Details page for employee with id 4,
 * and then asserts that the employee is an hourly employee, 
 * that the pay is a currency value,
 * and that searching for an employee with id 0 fails.
 * */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace UITest
{
    [TestClass]
    public class EmployeeDetailsTests
    {
        private IWebDriver? _driver;

        [TestInitialize]
        public void TestInitialize()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
        }

        // Create a test method 'SearchForEmployeeId4_ShouldSucceed' to navigate to the employee details page for employee with id 4
        // Use the URL 'https://localhost:7088/Employee/Details/4'
        // Use a try-catch block to catch any exceptions and fail the test if an exception occurs
        [TestMethod]
        public void SearchForEmployeeId4_ShouldSucceed()
        {
            try
            {
                _driver?.Navigate().GoToUrl("https://localhost:7088/Employee/Details/4");
            }
            catch (Exception)
            {
                Assert.Fail("Search for employee with id 4 failed");
            }
        }

        
        [TestCleanup]
        public void TestCleanup()
        {
            _driver?.Quit();
        }
    }
}

