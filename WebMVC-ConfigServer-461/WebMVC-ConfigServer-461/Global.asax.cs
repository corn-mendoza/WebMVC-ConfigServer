using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebMVC_ConfigServer_461
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var _env = Environment.GetEnvironmentVariable("RUNTIME_ENVIRONMENT");

            if (!string.IsNullOrEmpty(_env))
                ConfigServerConfig.RegisterConfig(_env);
            else
                ConfigServerConfig.RegisterConfig("dev");
        }
    }
}
