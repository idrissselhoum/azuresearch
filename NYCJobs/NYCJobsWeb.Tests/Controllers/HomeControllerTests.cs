using Microsoft.VisualStudio.TestTools.UnitTesting;
using NYCJobsWeb.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYCJobsWeb.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        HomeController controller;

        [TestInitialize]
        public void Init()
        {
            controller = new HomeController();
        }


        [TestMethod()]
        public void IndexTest()
        {
            controller.Index();
        }

        [TestMethod()]
        public void JobDetailsTest()
        {
            controller.JobDetails();
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void SearchTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void SuggestTest()
        {
            //var result = controller.Suggest("Analyst", true);
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void LookUpTest()
        {
            controller.LookUp("");
        }
    }
}