using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;

namespace Chloe.Api
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start()
        {            
            UnityConfig.RegisterComponents();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpContext.Current.Items["RouteParams"] = new Dictionary<string, string>();
        }

    }
}