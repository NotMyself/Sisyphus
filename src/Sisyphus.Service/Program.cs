using Autofac;
using Autofac.Configuration;
using Hangfire.Logging;
using Hangfire.Logging.LogProviders;
using Topshelf;

namespace Sisyphus.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            LogProvider.SetCurrentLogProvider(new ColouredConsoleLogProvider());

            var host = HostFactory.New(c =>
            {
                c.Service<Service>(s =>
                {
                    s.ConstructUsing(x => new Service(BuildContainer()));
                    s.WhenStarted(service => service.Start());
                    s.WhenStopped(service => service.Stop());
                });
                c.RunAsNetworkService();

                c.SetDescription("Runs Sisyphus background job processor.");
                c.SetDisplayName("Sisyphus");
                c.SetServiceName("Sisyphus");
            });

            host.Run();
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            var config = new ConfigurationSettingsReader("autofac");

            builder.RegisterModule(config);

            return builder.Build();
        }
    }
}
