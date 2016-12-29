using System;
using System.Threading.Tasks;
using Hangfire;
using Sisyphus.Core;

namespace Sisyphus.Jobs.Example
{
    public class ExampleJob : IBackgroundJob, IBackgroundJobSchedule, IBackgroundJobScheduler
    {

        public string GetSchedule()
        {
            return Cron.Hourly();
        }

        public void Schedule()
        {
            RecurringJob.AddOrUpdate<ExampleJob>(
                $"{nameof(ExampleJob)}",
                j => j.RunAsync(),
                GetSchedule());
        }

        public Task RunAsync()
        {
            Console.WriteLine($"Executing {nameof(ExampleJob)} at {DateTime.Now.ToShortTimeString()}");

            return Task.FromResult("OK");
        }
    }
}
