using System.Web;
using System.Web.Mvc;
using SimpleSite.Filters;

namespace SimpleSite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new NotificationFilter());
        }
    }
}
