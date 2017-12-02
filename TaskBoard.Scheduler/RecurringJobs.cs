using System;
using Hangfire;

namespace TaskBoard.Scheduler
{
    public class RecurringJobs
    {
        public void AddJob()
        {
            RecurringJob.AddOrUpdate(
                () => Console.WriteLine("Recurring!"),
                Cron.Daily);
        }
    }
}