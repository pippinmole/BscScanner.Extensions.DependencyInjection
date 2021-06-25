using System;
using Microsoft.Extensions.DependencyInjection;

namespace BscScanner.Extensions.DependencyInjection {
    public static class ServiceCollectionExtensions {

        public static IServiceCollection AddBscScanner(this IServiceCollection services, Action<BscScanClientOptions> options) {
            var opt = new BscScanClientOptions();
            if ( options != null ) options(opt);

            services.AddSingleton<IBscScanClient, BscScanClient>(x => new BscScanClient(opt.ApiKey));

            return services;
        }
    }
}