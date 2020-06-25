﻿using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace Pomoce
{
	public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Kod uruchamiany podczas uruchamiania aplikacji
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}