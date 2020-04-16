using System.Web;
using System.Web.Mvc;

namespace bot_o_mat_swetac14
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
