namespace TaskBoard.Scheduler
{
    using Hangfire;
    using System;
    using Microsoft.Owin.Hosting;

    class Program
    {
        static void Main()
        {
            using (WebApp.Start<Startup>("http://localhost:12345"))
            {
                Console.WriteLine("Hangfire Dashboard on");

                using (var server = new BackgroundJobServer())
                {
                    var jobId = BackgroundJob.Schedule(
                    () => Console.WriteLine("Delayed!"),
                    TimeSpan.FromMinutes(5));
                }
                Console.ReadKey();
            }

            
        }
    }
}
