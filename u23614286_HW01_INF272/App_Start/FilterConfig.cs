using System.Web;
using System.Web.Mvc;

namespace u23614286_HW01_INF272
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
