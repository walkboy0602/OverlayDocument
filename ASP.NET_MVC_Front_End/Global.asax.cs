using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcSample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private string _licensePath = "C:\\Users\\takas\\Desktop\\GroupDocs.Viewer-for-.NET-master\\Showcases\\ASP.NET_MVC_Front_End\\ASP.NET_MVC_Front_End\\App_Data\\GroupDocs.Viewer.lic";
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            GroupDocs.Viewer.License lic = new GroupDocs.Viewer.License();
            lic.SetLicense(_licensePath);
        }
    }
}
