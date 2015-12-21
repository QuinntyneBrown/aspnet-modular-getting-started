using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Chloe.Models;

namespace Chloe.Data.Migrations
{
    public class ComponentConfiguration
    {
        public static void Seed(ChloeContext context)
        {
            if (context.Components.Where(x => x.Name == "headerComponent").FirstOrDefault() == null)
                context.Components.Add(new Component() { Name = "headerComponent" });

            if (context.Components.Where(x => x.Name == "footerComponent").FirstOrDefault() == null)
                context.Components.Add(new Component() { Name = "footerComponent" });

            if (context.Components.Where(x => x.Name == "playerComponent").FirstOrDefault() == null)
                context.Components.Add(new Component() { Name = "playerComponent" });

            if (context.Components.Where(x => x.Name == "playersComponent").FirstOrDefault() == null)
                context.Components.Add(new Component() { Name = "playersComponent" });

            if (context.Components.Where(x => x.Name == "homeComponent").FirstOrDefault() == null)
                context.Components.Add(new Component() { Name = "homeComponent" });

            context.SaveChanges();
        }
    }
}
