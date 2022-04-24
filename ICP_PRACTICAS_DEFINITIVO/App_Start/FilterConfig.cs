using System.Web;
using System.Web.Mvc;

namespace ICP_PRACTICAS_DEFINITIVO
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
