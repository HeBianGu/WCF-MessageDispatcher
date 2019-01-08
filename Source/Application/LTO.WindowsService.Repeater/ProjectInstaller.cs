using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace LTO.WindowsService.Repeater
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }

        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);

            ServiceController sc = new ServiceController("LTO.WindwosServer.Repeater");

            if (sc.Status.Equals(ServiceControllerStatus.Stopped))
            {
                sc.Start();
            }
        }
        
    }
}
