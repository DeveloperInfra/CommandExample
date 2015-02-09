using System.Web;
using System.Web.Http;
using SimpleInjector;

namespace CommandExample.Api
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            // 1. Create a new Simple Injector container.
            var container = new Container();

            // 2. Configure the container.

            // 3. Initialize modules.
            //DomainConfiguration.Configure(container);
            WebConfiguration.Configure(container);

            // 4. Optionally verify the container's configuration.
            // Did you know the container can diagnose your configuration? Go to: https://simpleinjector.readthedocs.org/en/latest/diagnostics.html.
            container.Verify();

            // 5. Perform remaining Web API configuration.
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}