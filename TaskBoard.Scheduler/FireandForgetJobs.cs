using System;
using Hangfire;

namespace TaskBoard.Scheduler
{
    public class FireandForgetJobs
    {
        public void AddJob()
        {
            var jobId = BackgroundJob.Enqueue(() => Console.WriteLine("Fire-and-forget!"));
        }
    }
}