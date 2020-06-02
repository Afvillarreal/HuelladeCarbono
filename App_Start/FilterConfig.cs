using System.Web;
using System.Web.Mvc;

namespace Huella_de_Carbono
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
