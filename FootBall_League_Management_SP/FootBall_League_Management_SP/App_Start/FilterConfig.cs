using System.Web;
using System.Web.Mvc;

namespace FootBall_League_Management_SP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
