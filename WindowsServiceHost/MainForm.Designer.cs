namespace WindowsServiceHost
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartServer = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.btnInstallCertificates = new System.Windows.Forms.Button();
            this.btnUninstallCertificates = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartServer
            // 
            this.btnStartServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartServer.Location = new System.Drawing.Point(1, 1);
            this.btnStartServer.Margin = new System.Windows.Forms.Padding(1);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(134, 23);
            this.btnStartServer.TabIndex = 0;
            this.btnStartServer.Text = "Iniciar Servidor";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstall.Location = new System.Drawing.Point(137, 1);
            this.btnInstall.Margin = new System.Windows.Forms.Padding(1);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(134, 23);
            this.btnInstall.TabIndex = 1;
            this.btnInstall.Text = "Instalar Servicio";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnUninstall
            // 
            this.btnUninstall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUninstall.Location = new System.Drawing.Point(273, 1);
            this.btnUninstall.Margin = new System.Windows.Forms.Padding(1);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(134, 23);
            this.btnUninstall.TabIndex = 2;
            this.btnUninstall.Text = "Desinstalar Servicio";
            this.btnUninstall.UseVisualStyleBackColor = true;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // btnInstallCertificates
            // 
            this.btnInstallCertificates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstallCertificates.Location = new System.Drawing.Point(409, 1);
            this.btnInstallCertificates.Margin = new System.Windows.Forms.Padding(1);
            this.btnInstallCertificates.Name = "btnInstallCertificates";
            this.btnInstallCertificates.Size = new System.Drawing.Size(134, 23);
            this.btnInstallCertificates.TabIndex = 3;
            this.btnInstallCertificates.Text = "Instalar Certificados";
            this.btnInstallCertificates.UseVisualStyleBackColor = true;
            this.btnInstallCertificates.Click += new System.EventHandler(this.btnInstallCertificates_Click);
            // 
            // btnUninstallCertificates
            // 
            this.btnUninstallCertificates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUninstallCertificates.Location = new System.Drawing.Point(545, 1);
            this.btnUninstallCertificates.Margin = new System.Windows.Forms.Padding(1);
            this.btnUninstallCertificates.Name = "btnUninstallCertificates";
            this.btnUninstallCertificates.Size = new System.Drawing.Size(138, 23);
            this.btnUninstallCertificates.TabIndex = 4;
            this.btnUninstallCertificates.Text = "Desinstalar Certificados";
            this.btnUninstallCertificates.UseVisualStyleBackColor = true;
            this.btnUninstallCertificates.Click += new System.EventHandler(this.btnUninstallCertificates_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnUninstallCertificates, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInstallCertificates, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUninstall, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInstall, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStartServer, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 25);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtConsole);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 437);
            this.panel1.TabIndex = 3;
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.White;
            this.txtConsole.Location = new System.Drawing.Point(0, 0);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(682, 435);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.Button btnInstallCertificates;
        private System.Windows.Forms.Button btnUninstallCertificates;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtConsole;
    }
}

