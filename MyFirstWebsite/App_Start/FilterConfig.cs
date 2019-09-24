using System;
using System.Web.Mvc;

namespace MyFirstWebsite.App_Start
{
    public class FilterConfig
    {
        public FilterConfig()
        {
        }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute());
        }
    }
}
