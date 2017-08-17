using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
