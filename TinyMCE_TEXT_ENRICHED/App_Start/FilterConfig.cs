using System.Web;
using System.Web.Mvc;

namespace TinyMCE_TEXT_ENRICHED
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
