using System.Web;
using System.Web.Mvc;

namespace CryptoWallet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // Adds a global handle error attribute
            filters.Add(new HandleErrorAttribute());

            // You can add more global filters here
            // filters.Add(new AuthorizeAttribute());
            // filters.Add(new RequireHttpsAttribute());
        }
    }
}
