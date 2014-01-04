using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace ADP.DS.FrontOffice.Menu.ReportScheduler.WebApi.App_Start
{
    public class GlobalConfig
    {
        public static void Config(HttpConfiguration config)
        {
            // Remove Xml formatters. This means when we visit an endpoint from a browser, Instead of returning Xml, it will return Json.

            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // Creates camelCase support 
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            //TODO: need to discuss if Host will provide this "out of the box" 
            //config.Filters.Add(new ValidationActionFilter()); 

            //GlobalConfiguration.Configuration.Filters.Add(new DefaultExceptionFilter(new DefaultErrorSignal()));
        }


    }
}