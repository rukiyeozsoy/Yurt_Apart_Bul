using System.Web;
using System.Web.Mvc;

namespace Yurt_Apart_Bul
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
