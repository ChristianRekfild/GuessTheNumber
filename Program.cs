using GuessTheNumber.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var configuration = CreateConfigurationBuilder(args).Build();
            var serviceProvider = CreateIocContainer(configuration).BuildServiceProvider();
            var runner = serviceProvider.GetRequiredService<IApplicationRunner>();
            runner.Run();
        }

        private static IServiceCollection CreateIocContainer(IConfigurationRoot configuration)
        {
            var services = new ServiceCollection()
                            .UseStartup<Startup>(configuration)
                            ;

            return services;
        }

        private static IConfigurationBuilder CreateConfigurationBuilder(string[] args)
        {
            return new ConfigurationBuilder()
            .SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
            .AddJsonFile("appSettings.json", false, false)
            .AddEnvironmentVariables()
        ;
        }
    }
}
