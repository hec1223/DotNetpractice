using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MyFirstWebsite.App_Start;

namespace MyFirstWebsite
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
