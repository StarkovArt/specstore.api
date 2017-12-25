using System.Web.Http;
using System.Web.Mvc;

namespace Specstore.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
           // ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());
        }
    }
}
