namespace TaskBoard.Scheduler
{
    using Hangfire;
    using System;
    using Microsoft.Owin.Hosting;
    using System.ServiceProcess;
    class Program
    {
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new SchedulerService()
            };
            ServiceBase.Run(ServicesToRun);          
        }
    }
}
