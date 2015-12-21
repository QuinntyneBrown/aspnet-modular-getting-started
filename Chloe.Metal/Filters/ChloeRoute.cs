using Chloe.Metal.Contracts;
using System.Web.Mvc;
using Chloe.Metal.Extensions;

namespace Chloe.Metal.Filters
{
    public class ChloeRoute : ActionFilterAttribute
    {
        public ChloeRoute()
        {
            this.routeParamsProvider = DependencyResolver.Current.GetService<IRouteParamsProvider>();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            this.routeParamsProvider.Set("routeName", filterContext.RouteData.GetRouteName());

            foreach (var item in filterContext.RouteData.Values)
            {
                this.routeParamsProvider.Set(item.Key, item.Value);
            }
            base.OnActionExecuting(filterContext);
        }

        protected readonly IRouteParamsProvider routeParamsProvider;
    }
}