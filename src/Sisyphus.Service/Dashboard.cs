using System;
using Hangfire;
using Microsoft.Owin;
using Microsoft.Owin.Hosting;
using Owin;

[assembly: OwinStartup(typeof(Sisyphus.Service.Dashboard))]

namespace Sisyphus.Service
{
    public class Dashboard
    {
       public void Configuration(IAppBuilder app)
       {
           var options = new DashboardOptions
           {
               AppPath = null
           };
            app.UseHangfireDashboard("", options);
        }

        public static StartOptions Options => new StartOptions
        {
            Urls =
            {
                "http://+:8080"
            }
        };
    }
}