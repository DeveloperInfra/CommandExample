using System.Web.Http;
using CommandExample.Api.Services;
using Serilog;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;

namespace CommandExample.Api
{
    public static class WebConfiguration
    {
        public static void Configure(Container container)
        {
            ConfigureContainer(container);
            ConfigureWebApi(container, GlobalConfiguration.Configuration);
            ConfigureLogger(container);
        }

        private static void ConfigureContainer(Container container)
        {
            container.RegisterWebApiRequest<IRepository, ExampleRepository>();
            container.RegisterWebApiRequest<IRequestMessageProvider, RequestMessageProvider>();
        }

        //REF: https://simpleinjector.readthedocs.org/en/latest/webapiintegration.html
        private static void ConfigureWebApi(Container container, HttpConfiguration config)
        {
            container.RegisterWebApiControllers(config);
            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
            config.MapHttpAttributeRoutes();
            //config.Filters.Add(new TokenAuthenticationFilter(container.GetInstance<ITokenService>));
        }

        private static void ConfigureLogger(Container container)
        {
            var logger = new LoggerConfiguration()
                .Enrich.WithProperty("Version", "0.1.0")
                .MinimumLevel.Debug()
                .WriteTo.ColoredConsole()
                .CreateLogger();

            container.RegisterSingle(logger);
        }
    };
}