using Microsoft.VisualStudio.TestTools.UnitTesting;
using NYCJobsWeb.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

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
        }

        [TestMethod()]
        public void SearchTest()
        {
            string q = "*";
            string businessTitleFacet = "";
            string postingTypeFacet = "";
            string salaryRangeFacet = "";
            string sortType = "featured";
            double lat = 40.736224;
            double lon = -73.99251;
            int currentPage = 1;
            int maxDistance = 0;
            int zipCode = 10001;

            System.Web.Mvc.JsonResult result = (JsonResult)controller.Search(
                q,
                businessTitleFacet,
                postingTypeFacet,
                salaryRangeFacet,
                sortType,
                lat,
                lon,
                currentPage,
                zipCode,
                maxDistance);

            NYCJobsWeb.Models.NYCJob data = (NYCJobsWeb.Models.NYCJob)result.Data;

            Assert.IsTrue(data.Facets.Count > 0);
            Assert.IsTrue(data.Results.Count > 0);
        }

        [TestMethod()]
        public void LookUpTest()
        {
            controller.LookUp("");
        }
    }
}