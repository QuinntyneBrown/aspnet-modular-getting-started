using Chloe.Metal.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chloe.Metal.Extensions;

namespace Chloe.Metal.Filter
{
    public class ChloeRoute : ActionFilterAttribute
    {
        public ChloeRoute()
        {
            this.routeParamsProvider = DependencyResolver.Current.GetService<IRouteParamsProvider>();
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            this.routeParamsProvider.Set("routeName", filterContext.RouteData.GetRouteName());

            foreach (var item in filterContext.RouteData.Values)
            {
                this.routeParamsProvider.Set(item.Key, item.Value);
            }
            base.OnActionExecuted(filterContext);
        }

        protected readonly IRouteParamsProvider routeParamsProvider;
    }
}