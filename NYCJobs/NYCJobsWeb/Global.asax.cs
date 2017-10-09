﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.ApplicationInsights.SnapshotCollector;
using Microsoft.ApplicationInsights;

namespace NYCJobsWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //Set AppInsight Instrumentation Key
            Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration.Active.InstrumentationKey = WebConfigurationManager.AppSettings["AppInsight.InstrumentationKey"];
        }


        protected void Application_Error(object sender, EventArgs e)
        {
            TelemetryClient _telemetryClient = new TelemetryClient();
            _telemetryClient.TrackException(Server.GetLastError());
        }

    }
}