
namespace NetCheck
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.popupMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAppName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuChangeAdapterOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrayIconColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYellow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatus = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.lblDirty = new System.Windows.Forms.Label();
            this.pnlSMTP = new System.Windows.Forms.Panel();
            this.nmSMTPPort = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMailFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSMTPServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.pnlConfig1 = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.lblMailTo = new System.Windows.Forms.Label();
            this.tbMailTo = new System.Windows.Forms.TextBox();
            this.cbAutoSaveConfig = new System.Windows.Forms.CheckBox();
            this.cbWiredOnly = new System.Windows.Forms.CheckBox();
            this.popupMenu.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            this.pnlSMTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSMTPPort)).BeginInit();
            this.pnlConfig1.SuspendLayout();
            this.SuspendLayout();
            // 
            // popupMenu
            // 
            this.popupMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.popupMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAppName,
            this.toolStripSeparator1,
            this.mnuChangeAdapterOptions,
            this.mnuConfig,
            this.mnuTrayIconColor,
            this.toolStripSeparator2,
            this.mnuExit});
            this.popupMenu.Name = "contextMenuStrip1";
            this.popupMenu.Size = new System.Drawing.Size(251, 156);
            // 
            // mnuAppName
            // 
            this.mnuAppName.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.mnuAppName.ForeColor = System.Drawing.Color.Blue;
            this.mnuAppName.Image = ((System.Drawing.Image)(resources.GetObject("mnuAppName.Image")));
            this.mnuAppName.Name = "mnuAppName";
            this.mnuAppName.Size = new System.Drawing.Size(250, 28);
            this.mnuAppName.Text = "Net Checker";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(247, 6);
            // 
            // mnuChangeAdapterOptions
            // 
            this.mnuChangeAdapterOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuChangeAdapterOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuChangeAdapterOptions.Image")));
            this.mnuChangeAdapterOptions.Name = "mnuChangeAdapterOptions";
            this.mnuChangeAdapterOptions.Size = new System.Drawing.Size(250, 28);
            this.mnuChangeAdapterOptions.Text = "Change Adapter Options";
            this.mnuChangeAdapterOptions.Click += new System.EventHandler(this.mnuChangeAdapterOptions_Click);
            // 
            // mnuConfig
            // 
            this.mnuConfig.Image = ((System.Drawing.Image)(resources.GetObject("mnuConfig.Image")));
            this.mnuConfig.Name = "mnuConfig";
            this.mnuConfig.Size = new System.Drawing.Size(250, 28);
            this.mnuConfig.Text = "Config";
            this.mnuConfig.Click += new System.EventHandler(this.mnuConfig_Click);
            // 
            // mnuTrayIconColor
            // 
            this.mnuTrayIconColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWhite,
            this.mnuBlack,
            this.mnuYellow});
            this.mnuTrayIconColor.Name = "mnuTrayIconColor";
            this.mnuTrayIconColor.Size = new System.Drawing.Size(250, 28);
            this.mnuTrayIconColor.Text = "Tray icon color";
            // 
            // mnuWhite
            // 
            this.mnuWhite.CheckOnClick = true;
            this.mnuWhite.Name = "mnuWhite";
            this.mnuWhite.Size = new System.Drawing.Size(135, 26);
            this.mnuWhite.Text = "White";
            this.mnuWhite.Click += new System.EventHandler(this.mnuWhite_Click);
            // 
            // mnuBlack
            // 
            this.mnuBlack.CheckOnClick = true;
            this.mnuBlack.Name = "mnuBlack";
            this.mnuBlack.Size = new System.Drawing.Size(135, 26);
            this.mnuBlack.Text = "Black";
            this.mnuBlack.Click += new System.EventHandler(this.mnuWhite_Click);
            // 
            // mnuYellow
            // 
            this.mnuYellow.Checked = true;
            this.mnuYellow.CheckOnClick = true;
            this.mnuYellow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuYellow.Name = "mnuYellow";
            this.mnuYellow.Size = new System.Drawing.Size(135, 26);
            this.mnuYellow.Text = "Yellow";
            this.mnuYellow.Click += new System.EventHandler(this.mnuWhite_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(247, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Image = ((System.Drawing.Image)(resources.GetObject("mnuExit.Image")));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(250, 28);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(371, 65);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Network Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.popupMenu;
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // pnlConfig
            // 
            this.pnlConfig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlConfig.Controls.Add(this.lblDirty);
            this.pnlConfig.Controls.Add(this.pnlSMTP);
            this.pnlConfig.Controls.Add(this.pnlConfig1);
            this.pnlConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfig.Location = new System.Drawing.Point(0, 65);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(371, 304);
            this.pnlConfig.TabIndex = 1;
            // 
            // lblDirty
            // 
            this.lblDirty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDirty.ForeColor = System.Drawing.Color.Red;
            this.lblDirty.Location = new System.Drawing.Point(0, 280);
            this.lblDirty.Name = "lblDirty";
            this.lblDirty.Size = new System.Drawing.Size(367, 20);
            this.lblDirty.TabIndex = 18;
            this.lblDirty.Text = "Modified";
            this.lblDirty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDirty.Visible = false;
            // 
            // pnlSMTP
            // 
            this.pnlSMTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSMTP.Controls.Add(this.nmSMTPPort);
            this.pnlSMTP.Controls.Add(this.label6);
            this.pnlSMTP.Controls.Add(this.label5);
            this.pnlSMTP.Controls.Add(this.label4);
            this.pnlSMTP.Controls.Add(this.tbMailFrom);
            this.pnlSMTP.Controls.Add(this.label3);
            this.pnlSMTP.Controls.Add(this.tbPassword);
            this.pnlSMTP.Controls.Add(this.label2);
            this.pnlSMTP.Controls.Add(this.tbSMTPServer);
            this.pnlSMTP.Controls.Add(this.label1);
            this.pnlSMTP.Controls.Add(this.tbUserName);
            this.pnlSMTP.Location = new System.Drawing.Point(0, 107);
            this.pnlSMTP.Name = "pnlSMTP";
            this.pnlSMTP.Size = new System.Drawing.Size(367, 169);
            this.pnlSMTP.TabIndex = 7;
            // 
            // nmSMTPPort
            // 
            this.nmSMTPPort.Location = new System.Drawing.Point(301, 32);
            this.nmSMTPPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nmSMTPPort.Name = "nmSMTPPort";
            this.nmSMTPPort.Size = new System.Drawing.Size(55, 27);
            this.nmSMTPPort.TabIndex = 11;
            this.nmSMTPPort.ValueChanged += new System.EventHandler(this.tbMailTo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Port";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "SMTP Settings";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mail from";
            // 
            // tbMailFrom
            // 
            this.tbMailFrom.Location = new System.Drawing.Point(122, 131);
            this.tbMailFrom.Name = "tbMailFrom";
            this.tbMailFrom.Size = new System.Drawing.Size(233, 27);
            this.tbMailFrom.TabIndex = 15;
            this.tbMailFrom.TextChanged += new System.EventHandler(this.tbMailTo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(122, 98);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(140, 27);
            this.tbPassword.TabIndex = 13;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbMailTo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "SMTP Server";
            // 
            // tbSMTPServer
            // 
            this.tbSMTPServer.Location = new System.Drawing.Point(122, 32);
            this.tbSMTPServer.Name = "tbSMTPServer";
            this.tbSMTPServer.Size = new System.Drawing.Size(140, 27);
            this.tbSMTPServer.TabIndex = 9;
            this.tbSMTPServer.TextChanged += new System.EventHandler(this.tbMailTo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "User name";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(123, 65);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(140, 27);
            this.tbUserName.TabIndex = 11;
            this.tbUserName.TextChanged += new System.EventHandler(this.tbMailTo_TextChanged);
            // 
            // pnlConfig1
            // 
            this.pnlConfig1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfig1.Controls.Add(this.btSave);
            this.pnlConfig1.Controls.Add(this.lblMailTo);
            this.pnlConfig1.Controls.Add(this.tbMailTo);
            this.pnlConfig1.Controls.Add(this.cbAutoSaveConfig);
            this.pnlConfig1.Controls.Add(this.cbWiredOnly);
            this.pnlConfig1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConfig1.Location = new System.Drawing.Point(0, 0);
            this.pnlConfig1.Name = "pnlConfig1";
            this.pnlConfig1.Size = new System.Drawing.Size(367, 107);
            this.pnlConfig1.TabIndex = 1;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(301, 10);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(54, 53);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Save Now";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lblMailTo
            // 
            this.lblMailTo.AutoSize = true;
            this.lblMailTo.Location = new System.Drawing.Point(12, 70);
            this.lblMailTo.Name = "lblMailTo";
            this.lblMailTo.Size = new System.Drawing.Size(101, 20);
            this.lblMailTo.TabIndex = 5;
            this.lblMailTo.Text = "Send eMail to";
            // 
            // tbMailTo
            // 
            this.tbMailTo.Location = new System.Drawing.Point(122, 70);
            this.tbMailTo.Name = "tbMailTo";
            this.tbMailTo.Size = new System.Drawing.Size(233, 27);
            this.tbMailTo.TabIndex = 6;
            this.tbMailTo.TextChanged += new System.EventHandler(this.tbMailTo_TextChanged);
            // 
            // cbAutoSaveConfig
            // 
            this.cbAutoSaveConfig.AutoSize = true;
            this.cbAutoSaveConfig.Location = new System.Drawing.Point(11, 40);
            this.cbAutoSaveConfig.Name = "cbAutoSaveConfig";
            this.cbAutoSaveConfig.Size = new System.Drawing.Size(274, 24);
            this.cbAutoSaveConfig.TabIndex = 3;
            this.cbAutoSaveConfig.Text = "Save the configuration automatically";
            this.cbAutoSaveConfig.UseVisualStyleBackColor = true;
            this.cbAutoSaveConfig.CheckStateChanged += new System.EventHandler(this.tbMailTo_TextChanged);
            this.cbAutoSaveConfig.Click += new System.EventHandler(this.cbAutoSaveConfig_Click);
            // 
            // cbWiredOnly
            // 
            this.cbWiredOnly.AutoSize = true;
            this.cbWiredOnly.Location = new System.Drawing.Point(11, 10);
            this.cbWiredOnly.Name = "cbWiredOnly";
            this.cbWiredOnly.Size = new System.Drawing.Size(175, 24);
            this.cbWiredOnly.TabIndex = 2;
            this.cbWiredOnly.Text = "Check wired LAN only";
            this.cbWiredOnly.UseVisualStyleBackColor = true;
            this.cbWiredOnly.CheckStateChanged += new System.EventHandler(this.tbMailTo_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 369);
            this.Controls.Add(this.pnlConfig);
            this.Controls.Add(this.lblStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "NetCheck";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Move += new System.EventHandler(this.Main_Move);
            this.popupMenu.ResumeLayout(false);
            this.pnlConfig.ResumeLayout(false);
            this.pnlSMTP.ResumeLayout(false);
            this.pnlSMTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSMTPPort)).EndInit();
            this.pnlConfig1.ResumeLayout(false);
            this.pnlConfig1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip popupMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuConfig;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeAdapterOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuAppName;
        private System.Windows.Forms.Panel pnlConfig;
        private System.Windows.Forms.Panel pnlSMTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMailFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSMTPServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Panel pnlConfig1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lblMailTo;
        private System.Windows.Forms.TextBox tbMailTo;
        private System.Windows.Forms.CheckBox cbAutoSaveConfig;
        private System.Windows.Forms.CheckBox cbWiredOnly;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmSMTPPort;
        private System.Windows.Forms.Label lblDirty;
        private System.Windows.Forms.ToolStripMenuItem mnuTrayIconColor;
        private System.Windows.Forms.ToolStripMenuItem mnuWhite;
        private System.Windows.Forms.ToolStripMenuItem mnuBlack;
        private System.Windows.Forms.ToolStripMenuItem mnuYellow;
    }
}

