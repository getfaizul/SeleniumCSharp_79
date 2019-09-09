using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Configuration;
using SeleniumWebdriver.Interfaces;
using SeleniumWebdriver.PageObject;
using SeleniumWebdriver.Settings;


namespace SeleniumWebdriver
{
  
    [TestClass]
    public class UnitTest1
    {
        private TestContext _testContext;

        public TestContext TestContext
        {
            get { return _testContext; }
            set { _testContext = value; }
        }

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(TestContext.TestName);

        }


        [TestMethod]
        public void TestMethod2()
        {

            Console.WriteLine(TestContext.TestName);
        }

        [TestCleanup]
        public void afterTest()
        {
            Console.WriteLine(TestContext.TestName + " " + TestContext.CurrentTestOutcome);
        }
    }
}
