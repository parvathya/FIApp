using System.Reflection;
using System.Web.Http;
using AttributeRouting.Web.Constraints;
using AttributeRouting.Web.Http.WebHost;

[assembly: WebActivator.PreApplicationStartMethod(typeof(ADP.DS.FrontOffice.Menu.ReportScheduler.WebApi.AttributeRoutingHttpConfig), "Start")]

namespace ADP.DS.FrontOffice.Menu.ReportScheduler.WebApi 
{
    public static class AttributeRoutingHttpConfig
	{
		public static void RegisterRoutes(HttpRouteCollection routes) 
		{    
            routes.MapHttpAttributeRoutes(
                                config =>
                                {
                                    config.AddRoutesFromAssembly(Assembly.GetExecutingAssembly());
                                    config.AddDefaultRouteConstraint(@"^id$", new RegexRouteConstraint(@"^\d+$"));
                                });
		}

        public static void Start() 
		{
            RegisterRoutes(GlobalConfiguration.Configuration.Routes);
        }
    }
}
