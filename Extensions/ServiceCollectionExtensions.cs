using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Extensions
{
    public static class ServiceCollectionExtensions
    {
        private const string ConfigureServicesMethodName = "ConfigureServices";

        public static IServiceCollection UseStartup<TStartup>(this IServiceCollection services, IConfiguration configuration)
            where TStartup : class
        {
            var startupType = typeof(TStartup);
            var cfgServicesMethod = startupType.GetMethod(ConfigureServicesMethodName, new Type[] { typeof(IServiceCollection) });
            var hasConfigCtor = startupType.GetConstructor(new Type[] { typeof(IConfiguration) }) != null;
            var startup = hasConfigCtor
                        ? (TStartup)Activator.CreateInstance(typeof(TStartup), configuration)
                        : (TStartup)Activator.CreateInstance(typeof(TStartup), null);


            cfgServicesMethod?.Invoke(startup, new object[] { services });


            return services;
        }

    }
}
