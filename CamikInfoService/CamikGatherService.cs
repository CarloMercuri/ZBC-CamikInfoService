using CamikInfoService.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CamikInfoService
{
    public partial class CamikGatherService : ServiceBase
    {
        private Timer mainTimer = null;
        private InfoGatheringControl control = new InfoGatheringControl();

        public CamikGatherService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

            mainTimer = new Timer();
            this.mainTimer.Interval = 30000; //every 30 secs
            this.mainTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.timerTick);
            mainTimer.Enabled = true;

            control.LogInformation();
        }

        private void timerTick(object sender, ElapsedEventArgs e)
        {
            control.LogInformation();
        }

        protected override void OnStop()
        {
        }
    }
}
