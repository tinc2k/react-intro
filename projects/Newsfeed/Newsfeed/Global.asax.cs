using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using Newsfeed.App_Start;
using System.Web.Optimization;
using System.Diagnostics;

namespace Newsfeed
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Session_OnStart(object sender, EventArgs e)
        {
            Debug.WriteLine("{0} [NewsFeed] Session Id {1} started.", DateTime.Now, Session.SessionID);
        }
    }
}