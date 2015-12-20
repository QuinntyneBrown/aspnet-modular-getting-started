using Chloe.Metal.Contracts;
using System.Collections.Generic;
using System.Web;
using System;

namespace Chloe.Metal
{
    public class RouteParamsProvider : IRouteParamsProvider
    {
        public Dictionary<string, string> Get()
        {
            return (HttpContext.Current.Items["RouteParams"] ??
                (HttpContext.Current.Items["RouteParams"] =
                new Dictionary<string, string>())) as Dictionary<string, string>;
        }

        public void Set(string key, string value)
        {
            var routeParams = Get();
            routeParams.Add(key, value);
            HttpContext.Current.Items["RouteParams"] = routeParams;
        }
    }
}
