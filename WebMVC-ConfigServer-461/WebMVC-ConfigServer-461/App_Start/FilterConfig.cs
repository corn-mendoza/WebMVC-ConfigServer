using System.Web;
using System.Web.Mvc;

namespace WebMVC_ConfigServer_461
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
