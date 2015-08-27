using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.ServiceProcess;
using System.Windows.Forms;

namespace WindowsServiceHost
{
    [RunInstaller(true)]
    public abstract class ServiceHost : Installer
    {
        public string ServiceName { get; private set; }
        public string ServiceDescription { get; private set; }
        protected List<CertificateInfo> CertificatesInfo { get; private set; }

        private Assembly assembly;
        private ServiceProcessInstaller serviceProcessInstaller;
        private ServiceInstaller serviceInstaller;

        public static void Run(ServiceHost serviceManager)
        {
            if (System.Environment.UserInteractive)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm(serviceManager));
            }
            else
            {
                ServiceBase.Run(new WindowsService(serviceManager));
            }
        }

        public ServiceHost(string serviceName, string serviceDescription)
        {
            ServiceName = serviceName;
            ServiceDescription = serviceDescription;
            assembly = Assembly.GetCallingAssembly();
            CertificatesInfo = new List<CertificateInfo>();
            serviceProcessInstaller = new ServiceProcessInstaller();
            serviceProcessInstaller.Account = ServiceAccount.LocalSystem;
            serviceProcessInstaller.Username = null;
            serviceProcessInstaller.Password = null;
            serviceInstaller = new ServiceInstaller();
            serviceInstaller.Description = ServiceDescription;
            serviceInstaller.DisplayName = ServiceName;
            serviceInstaller.ServiceName = ServiceName;
            serviceInstaller.StartType = ServiceStartMode.Automatic;
            Installers.AddRange(new Installer[] { this.serviceProcessInstaller, this.serviceInstaller });
        }

        public abstract bool Active { get; }
        public abstract bool Start();
        public abstract bool Stop();

        public bool Install()
        {
            try
            {
                ManagedInstallerClass.InstallHelper(new string[] { assembly.Location });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Uninstall()
        {
            try
            {
                ManagedInstallerClass.InstallHelper(new string[] { "/u", assembly.Location });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InstallCertificates()
        {
            X509Store store;
            X509Certificate2Collection certificates;
            try
            {
                foreach (var info in CertificatesInfo)
                {
                    store = new X509Store(info.StoreName, info.StoreLocation);
                    store.Open(OpenFlags.ReadWrite);
                    certificates = store.Certificates.Find(X509FindType.FindBySerialNumber, info.Certificate.GetSerialNumberString(), false);
                    if (certificates.Count == 0)
                        store.Add(info.Certificate);
                    store.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UninstallCertificates()
        {
            X509Store store;
            X509Certificate2Collection certificates;
            try
            {
                foreach (var info in CertificatesInfo)
                {
                    store = new X509Store(info.StoreName, info.StoreLocation);
                    store.Open(OpenFlags.ReadWrite);
                    certificates = store.Certificates.Find(X509FindType.FindBySerialNumber, info.Certificate.GetSerialNumberString(), false);
                    if (certificates.Count > 0)
                        store.Remove(info.Certificate);
                    store.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        protected class CertificateInfo
        {
            public StoreName StoreName { get; private set; }
            public StoreLocation StoreLocation { get; private set; }
            public X509Certificate2 Certificate { get; private set; }

            public CertificateInfo(StoreName storeName, StoreLocation storeLocation, X509Certificate2 certificate)
            {
                StoreName = storeName;
                StoreLocation = storeLocation;
                Certificate = certificate;
            }
        }
    }
}