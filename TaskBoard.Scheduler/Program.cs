using System.ServiceProcess;

namespace TaskBoard.Scheduler
{
    internal class Program
    {
        private static void Main()
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