using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYCJobsWeb.AcceptanceTests.Pages
{
    public abstract class SeleniumPage
    {
        public IWebDriver Driver { get; }

        public SeleniumPage(IWebDriver driver)
        {
            this.Driver = driver;
        }
    }
}
