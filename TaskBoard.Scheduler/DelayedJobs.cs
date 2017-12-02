using System;
using Hangfire;

namespace TaskBoard.Scheduler
{
    public class DelayedJobs
    {
        public void AddJob()
        {
            var jobId = BackgroundJob.Schedule(
                () => Console.WriteLine("Delayed!"),
                TimeSpan.FromDays(7));
        }
    }
}