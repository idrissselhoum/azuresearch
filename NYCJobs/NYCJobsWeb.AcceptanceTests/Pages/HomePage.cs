using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NYCJobsWeb.AcceptanceTests.Pages
{
    public class HomePage : SeleniumPage
    {

        public static string Url { get; set; }

        public HomePage(IWebDriver driver, string url) : base(driver)
        {
            Url = url;
        }

        public HomePage GoTo()
        {
            this.Driver.Navigate().GoToUrl(Url);
            return this;
        }

        public int JobsCount
        {
            get
            {
                //TODO: update this code to return the number of results 
                int value = 0;
                var result = int.TryParse(Driver.FindElement(By.Id("jobs-count")).Text, out value);
                return result ? value : 0;
            }
        }


        public IWebElement SearchTextBox
        {
            get { return Driver.FindElement(By.Id("sb_form_q")); }
        }

        public IWebElement SearchButton
        {
            get { return Driver.FindElement(By.Id("sb_form_go")); }
        }

        public IWebElement FirstSearchResult
        {
            get { return Driver.FindElement(By.XPath("//ol[@id='b_results']/li/h2/a")); }
        }

        public void EnterSearchText(string text)
        {
            SearchTextBox.SendKeys(text);
        }

        public HomePage SearchFor(string text)
        {
            var searchbox = this.Driver.FindElement(By.Id("q"));

            searchbox.SendKeys("Analyst");

            var submitButton = this.Driver.FindElement(By.ClassName("search-submit"));

            submitButton.Click();

            return this;
        }
    }
}
