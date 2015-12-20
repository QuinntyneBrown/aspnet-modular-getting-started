using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Serialization;
using Unity.WebApi;
using Newtonsoft.Json;


namespace Chloe.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            var jSettings = new JsonSerializerSettings();
            
            jSettings.Formatting = Formatting.Indented;

            var serializer = JsonSerializer.Create(jSettings);
            
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            config.Formatters.JsonFormatter.SerializerSettings = jSettings;
            
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new {
                    controller = "Home",
                    id = RouteParameter.Optional }
            );
        }
    }
}