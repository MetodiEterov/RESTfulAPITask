using System.Net.Http;
using System.Security.Cryptography.X509Certificates;

using Entity.Layer.Contracts;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Repository.Layer;

namespace WebAPI.Layer.Common
{
    /// <summary>
    /// ServiceExtensions class
    /// </summary>
    public static class ServiceExtensions
    {
        /// <summary>
        /// ConfigureServicesInjection method
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void ConfigureServicesInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IOrderRepository, OrderRepository>();
            services.AddHttpClient();

            var clientCertificateIntermediate = new X509Certificate2("yyyyy.pfx", configuration["CertificationPassword"]);
            var handlerClientCertificateIntermediate = new HttpClientHandler();
            handlerClientCertificateIntermediate.ClientCertificates.Add(clientCertificateIntermediate);

            services.AddHttpClient("client", c => { })
                .ConfigurePrimaryHttpMessageHandler(() => handlerClientCertificateIntermediate);

            services.AddControllersWithViews();

            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        } 
    }
}
