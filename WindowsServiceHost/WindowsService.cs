using System.ServiceProcess;

namespace WindowsServiceHost
{
    public class WindowsService : ServiceBase
    {
        ServiceHost serviceManager;

        public WindowsService(ServiceHost serviceManager)
        {
            this.serviceManager = serviceManager;
            ServiceName = serviceManager.ServiceName;
            CanStop = true;
            AutoLog = true;
            EventLog.Log = "Application";
            EventLog.Source = serviceManager.ServiceName;
        }

        protected override void OnStart(string[] args)
        {
            serviceManager.Start();
        }

        protected override void OnStop()
        {
            serviceManager.Stop();
        }
    }
}
