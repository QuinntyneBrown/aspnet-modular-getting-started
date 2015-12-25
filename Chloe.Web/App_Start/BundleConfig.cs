using Chloe.ViewModels;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Optimization;

namespace Chloe.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var bundle = new ScriptBundle("~/bundles/app");

            foreach (var assembly in GetViewComponenAssemblies())
            {
                foreach (var dep in GetClientDenpendecyAttributes(assembly)) {
                    bundle.Include(dep.FullFileName);
                };
            }
            
            bundles.Add(bundle);
            BundleTable.EnableOptimizations = true;
        }

        public static ICollection<Assembly> GetViewComponenAssemblies()
        {
            return System.Web.Compilation.BuildManager.GetReferencedAssemblies()
                .Cast<Assembly>()
                .Where(a => a.GetName().Name.StartsWith("Chloe.ViewComponents") == true).ToList();
        }


        public static List<ClientDenpendencyAttribute> GetClientDenpendecyAttributes(Assembly assembly)
        {
            List<ClientDenpendencyAttribute> attributes = new List<ClientDenpendencyAttribute>();
            foreach (Type type in assembly.GetTypes())
            {
                foreach(var arr in type.GetCustomAttributes(typeof(ClientDenpendencyAttribute), true))
                {
                    attributes.Add(arr as ClientDenpendencyAttribute);
                }
            }

            return attributes;
        }
    }
}