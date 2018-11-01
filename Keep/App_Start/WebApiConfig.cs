using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Keep
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));
            // Web API 配置和服务
            config.Formatters.JsonFormatter.SerializerSettings.Converters.Add(new IsoDateTimeConverter()
            {
                DateTimeFormat = "yyyy-MM-dd"
            });
            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                 name: "DefaultApi",
                 routeTemplate: "api/{controller}/{action}/{id}",
                 defaults: new { action = RouteParameter.Optional, id = RouteParameter.Optional }
             );
        }
    }
}
