using System.Reflection;
using System.Web.Http;
using ADP.DS.FrontOffice.FI.App_Start;
using AttributeRouting.Web.Constraints;
using AttributeRouting.Web.Http.WebHost;

[assembly: WebActivator.PreApplicationStartMethod(typeof(AttributeRoutingHttpConfig), "Start")]

namespace ADP.DS.FrontOffice.FI.App_Start 
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
