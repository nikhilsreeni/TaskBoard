using Hangfire;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoard.Scheduler
{
    partial class SchedulerService : ServiceBase
    {

        public string baseAddress = "http://localhost:12345";
        private IDisposable _server = null;
        private IDisposable _schedulerServer = null;

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
