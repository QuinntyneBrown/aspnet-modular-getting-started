using Chloe.Metal;
using System;
using System.Web.Hosting;
using System.Web.Routing;
using System.Reflection;
using System.Linq;

namespace Chloe.Web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //var assemblies = System.Web.Compilation.BuildManager.GetReferencedAssemblies()
            //    .Cast<Assembly>()
            //    .Where(a => a.GetName().Name.StartsWith("Chloe") == true);
            //System.Web.Hosting.HostingEnvironment.RegisterVirtualPathProvider(new Chloe.Metal.VirtualPathProvider(assemblies.ToArray())
            //{
            //    //you can do a specific assembly registration too. If you provide the assemly source path, it can read
            //    //from the source file so you can change the content while the app is running without needing to rebuild
            //    //{typeof(SomeAssembly.SomeClass).Assembly, @"..\SomeAssembly"} 
            //});

            UnityConfig.RegisterComponents();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

    }
}