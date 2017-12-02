using System;
using System.ServiceProcess;

namespace TaskBoard.Scheduler
{
    internal partial class SchedulerService : ServiceBase
    {
        private readonly IDisposable _schedulerServer = null;
        private readonly IDisposable _server = null;

        public string baseAddress = "http://localhost:12345";

        public SchedulerService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //_server = WebApp.Start<Startup>(url: baseAddress);
            //_schedulerServer = new BackgroundJobServer();
        }

        protected override void OnStop()
        {
            if (_server != null)
            {
                _server.Dispose();
            }
            if (_schedulerServer != null)
            {
                _schedulerServer.Dispose();
            }
            base.OnStop();
        }
    }
}