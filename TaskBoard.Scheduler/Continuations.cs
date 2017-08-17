using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoard.Scheduler
{
    public class Continuations
    {
        public void AddJob()
        {
            //BackgroundJob.ContinueWith(
            //jobId,
            //() => Console.WriteLine("Continuation!"));
        }
    }
}
