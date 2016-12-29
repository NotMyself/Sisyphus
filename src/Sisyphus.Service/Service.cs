using System;
using Autofac;
using Hangfire;
using Microsoft.Owin.Hosting;

namespace Sisyphus.Service
{
    public class Service
    {
        private BackgroundJobServer _server;
        private IDisposable _dashboard;
        private readonly IContainer _container;

        public Service(IContainer container)
        {
            _container = container;
            GlobalConfiguration.Configuration.UseSqlServerStorage("JobStorage");
            GlobalConfiguration.Configuration.UseAutofacActivator(_container, false);
        }
        public void Start()
        {
            _dashboard = WebApp.Start<Dashboard>(Dashboard.Options);
            _server = new BackgroundJobServer();
            new Scheduler().Schedule(_container);
        }

        public void Stop()
        {
            _dashboard.Dispose();
            _server.Dispose();

        }
    }
}