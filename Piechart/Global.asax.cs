﻿using System.Web.Mvc;
using System.Web.Routing;
using Barchart;

namespace Piechart
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

        }
    }
}
