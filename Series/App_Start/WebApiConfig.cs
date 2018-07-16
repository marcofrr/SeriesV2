using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Series
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Desligar o formatador do XML.
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // Impedir referências circulares no JSON.
            // Nota: isto é uma má ideia, porque esconde erros no nosso código.
            // É preferível usar a anotação [JsonIgnore] no campo que se quer ignorar.
            //config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = 
            //    Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            // Pretty-print do JSON
            config.Formatters.JsonFormatter.SerializerSettings.Formatting =
                Newtonsoft.Json.Formatting.Indented;
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "Series",
                routeTemplate: "api/{controller}/",
                defaults: new { controller = "Series" }
            );

        }
    }
}
