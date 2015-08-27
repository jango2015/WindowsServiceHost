using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsServiceHost
{
    public partial class MainForm : Form
    {
        private ServiceHost serviceManager;

        public MainForm(ServiceHost serviceManager)
        {
            InitializeComponent();
            Text = String.Format("{0} ({1})", serviceManager.ServiceDescription, serviceManager.ServiceName);
            Console.SetOut(new TextBoxStreamWriter(txtConsole));
            this.serviceManager = serviceManager;
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            if (!serviceManager.Active)
            {
                if (serviceManager.Start())
                {
                    ConsoleLog("El servicio está iniciado...", Color.Cyan);
                    btnStartServer.Text = "Detener Servidor";
                }
                else
                    ConsoleLog("El servicio no pudo ser iniciado...", Color.Red);
            }
            else
            {
                if (serviceManager.Stop())
                {
                    ConsoleLog("El servicio está detenido...", Color.Yellow);
                    btnStartServer.Text = "Iniciar Servidor";
                }
                else
                    ConsoleLog("El servicio no pudo ser detenido...", Color.Red);
            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            if (serviceManager.Install())
                ConsoleLog("El servicio se ha instalado correctamente.", Color.Green);
            else
                ConsoleLog("Ha ocurrido un error instalando el servicio.", Color.Red);
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            if (serviceManager.Uninstall())
                ConsoleLog("El servicio se ha desinstalado correctamente.", Color.Green);
            else
                ConsoleLog("Ha ocurrido un error desinstalando el servicio.", Color.Red);
        }

        private void btnInstallCertificates_Click(object sender, EventArgs e)
        {
            if (serviceManager.InstallCertificates())
                ConsoleLog("Se han instalado los certificados.", Color.Green);
            else
                ConsoleLog("Se ha producido un error al instalar los certificados.", Color.Red);
        }

        private void btnUninstallCertificates_Click(object sender, EventArgs e)
        {
            if (serviceManager.UninstallCertificates())
                ConsoleLog("Se han desinstalado los certificados.", Color.Green);
            else
                ConsoleLog("Se ha producido un error al desinstalar los certificados.", Color.Red);
        }

        private void ConsoleLog(string message, Color color)
        {
            txtConsole.SelectionLength = 0;
            txtConsole.SelectionStart = txtConsole.TextLength;
            txtConsole.SelectionColor = color;
            if (!message.StartsWith("\r\n"))
                message = String.Format("{0}\r\n", message);
            txtConsole.AppendText(message);
            txtConsole.ScrollToCaret();
            txtConsole.SelectionColor = txtConsole.ForeColor;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            serviceManager.Stop();
        }
    }

    public class TextBoxStreamWriter : TextWriter
    {
        RichTextBox output = null;
        StringBuilder buffer = new StringBuilder();

        public TextBoxStreamWriter(RichTextBox output)
        {
            this.output = output;
            buffer = new StringBuilder();
        }

        public override void Write(char value)
        {
            if (output.InvokeRequired)
                output.Invoke(new Action<char>(Write), value);
            else
            {
                buffer.Append(value);
                if (value == '\n')
                {
                    output.AppendText(buffer.ToString());
                    output.ScrollToCaret();
                    buffer.Clear();
                }
            }
        }

        public override Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
}
