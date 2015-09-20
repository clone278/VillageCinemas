using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace VillageCinemas.WindowsService
{
    public partial class AardvarkService : ServiceBase
    {
        public AardvarkService()
        {
            InitializeComponent();

            this.ServiceName = "Aardvark Service";
            this.EventLog.Log = "Application";

            this.CanStop = true;
        }

        protected override void OnStart(string[] args)
        {
            base.OnStart(args);
        }

        protected override void OnStop()
        {
            base.OnStop();
        }
    }
}
