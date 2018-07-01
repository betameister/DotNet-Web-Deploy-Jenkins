using System.Web;
using System.Web.Mvc;

namespace DotNet_Web_Deploy_Jenkins
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
