using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CommandExample.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            jsonFormatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;

            // Remove default XML handler
            var matches = config.Formatters
                .Where(f => f.SupportedMediaTypes
                    .Any(m => m.MediaType.ToString() == "application/xml"
                              || m.MediaType.ToString() == "text/xml"))
                .ToList();
            foreach (var match in matches)
            {
                config.Formatters.Remove(match);
            }
        }
    }
}