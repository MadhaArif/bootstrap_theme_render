using System.Web;
using System.Web.Mvc;

namespace bootstrap_theme_render
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
