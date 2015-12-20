using Chloe.Metal.Contracts;
using System.Collections.Generic;
using System.Web;
using System;

namespace Chloe.Metal
{
    public class RouteParamsProvider : IRouteParamsProvider
    {
        public Dictionary<string, object> Get()
        {
            return (HttpContext.Current.Items["RouteParams"] ??
                (HttpContext.Current.Items["RouteParams"] =
                new Dictionary<string, object>())) as Dictionary<string, object>;
        }

        public void Set(string key, object value)
        {
            var routeParams = Get();
            routeParams[key] = value;
            HttpContext.Current.Items["RouteParams"] = routeParams;
        }
    }
}
