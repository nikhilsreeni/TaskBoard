using System.ComponentModel;
using System.Configuration.Install;

namespace TaskBoard.Scheduler
{
    [RunInstaller(true)]
    public partial class TaskBoardInstaller : Installer
    {
        public TaskBoardInstaller()
        {
            InitializeComponent();
        }
    }
}