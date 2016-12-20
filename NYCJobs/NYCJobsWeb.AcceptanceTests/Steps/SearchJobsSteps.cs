﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using NYCJobsWeb.AcceptanceTests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Drawing;
using System.IO;
using TechTalk.SpecFlow;

namespace NYCJobsWeb.AcceptanceTests.Steps
{
    [Binding]
    public class SearchJobsSteps
    {
        //    Given I navigate on the home page
        //When I have entered Analyst in the request form and press search button
        //Then the result shall return at least 1 job
        protected static IWebDriver _driver;
        protected static HomePage Page;


        protected string DriversFolder { get; set; }


        [BeforeScenario]
        public void InitScenario()
        {
            DriversFolder = Directory.GetCurrentDirectory() + @"\Tools";
            try
            {
                _driver = new PhantomJSDriver(DriversFolder);
                //_driver = new ChromeDriver(DriversFolder);

                _driver.Manage().Window.Size = new Size(1024, 768);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Current Folder:{0} ; ChromeDriverFolder={1}", Directory.GetCurrentDirectory(), DriversFolder), ex);
            }
        }


        [AfterScenario]
        public void TearDownScenario()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        [Given(@"I navigate on the home page")]
        public void GivenINavigateOnTheHomePage()
        {
            Page = new HomePage(_driver);
            Page.GoTo();
            Check.That("Azure Search - Job Portal Demo").Equals(_driver.Title);
        }

        [When(@"I have entered Analyst in the request form and press search button")]
        public void WhenIHaveEnteredAnalystInTheRequestFormAndPressSearchButton()
        {
            try
            {
                Page.SearchFor("Analyst");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }


        [Then(@"the result shall return at least (.*) job")]
        public void ThenTheResultShallReturnAtLeastJob(int p0)
        {
            Check.That(Page.JobsCount).IsGreaterThan(p0);

            //TODO: check that the request returns more than 1 result
        }

    }
}
