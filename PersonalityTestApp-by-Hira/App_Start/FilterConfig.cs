using System.Web;
using System.Web.Mvc;

namespace PersonalityTestApp_by_Hira
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
