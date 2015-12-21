using Chloe.Models;
using System.Linq;

namespace Chloe.Data.Migrations
{
    public class PageConfiguration
    {
        public static void Seed(ChloeContext context)
        {
            if (context.Pages.Where(x => x.RouteName == "Default").FirstOrDefault() == null)
            {
                var page = new Page() { Name = "Default", RouteName = "Default" };
                page.Components.Add(context.Components.First(x => x.Name == "headerComponent"));
                page.Components.Add(context.Components.First(x => x.Name == "footerComponent"));
                page.Components.Add(context.Components.First(x => x.Name == "homeComponent"));
                context.Pages.Add(page);
            }

            if (context.Pages.Where(x => x.RouteName == "Player").FirstOrDefault() == null)
            {
                var page = new Page() { Name = "Player", RouteName = "Player" };
                page.Components.Add(context.Components.First(x => x.Name == "headerComponent"));
                page.Components.Add(context.Components.First(x => x.Name == "footerComponent"));
                page.Components.Add(context.Components.First(x => x.Name == "playerComponent"));
                context.Pages.Add(page);
            }

            if (context.Pages.Where(x => x.RouteName == "Players").FirstOrDefault() == null)
            {
                var page = new Page() { Name = "Players", RouteName = "Players" };
                page.Components.Add(context.Components.First(x => x.Name == "headerComponent"));
                page.Components.Add(context.Components.First(x => x.Name == "footerComponent"));
                page.Components.Add(context.Components.First(x => x.Name == "playersComponent"));
                context.Pages.Add(page);
            }

            context.SaveChanges();

        }
    }
}
