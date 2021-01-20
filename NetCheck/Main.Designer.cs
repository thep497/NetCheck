
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatus = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.lblMailTo = new System.Windows.Forms.Label();
            this.tbMailTo = new System.Windows.Forms.TextBox();
            this.cbAutoSaveConfig = new System.Windows.Forms.CheckBox();
            this.cbWiredOnly = new System.Windows.Forms.CheckBox();
            this.popupMenu.SuspendLayout();
            this.pnlConfig.SuspendLayout();
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
            this.toolStripSeparator2,
            this.mnuExit});
            this.popupMenu.Name = "contextMenuStrip1";
            this.popupMenu.Size = new System.Drawing.Size(251, 128);
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
            this.lblStatus.Size = new System.Drawing.Size(368, 65);
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
            this.pnlConfig.Controls.Add(this.btSave);
            this.pnlConfig.Controls.Add(this.lblMailTo);
            this.pnlConfig.Controls.Add(this.tbMailTo);
            this.pnlConfig.Controls.Add(this.cbAutoSaveConfig);
            this.pnlConfig.Controls.Add(this.cbWiredOnly);
            this.pnlConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfig.Location = new System.Drawing.Point(0, 65);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(368, 179);
            this.pnlConfig.TabIndex = 1;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(300, 10);
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
            this.lblMailTo.Location = new System.Drawing.Point(11, 70);
            this.lblMailTo.Name = "lblMailTo";
            this.lblMailTo.Size = new System.Drawing.Size(104, 20);
            this.lblMailTo.TabIndex = 3;
            this.lblMailTo.Text = "Send eMail to:";
            // 
            // tbMailTo
            // 
            this.tbMailTo.Location = new System.Drawing.Point(121, 70);
            this.tbMailTo.Name = "tbMailTo";
            this.tbMailTo.Size = new System.Drawing.Size(233, 27);
            this.tbMailTo.TabIndex = 2;
            // 
            // cbAutoSaveConfig
            // 
            this.cbAutoSaveConfig.AutoSize = true;
            this.cbAutoSaveConfig.Location = new System.Drawing.Point(10, 40);
            this.cbAutoSaveConfig.Name = "cbAutoSaveConfig";
            this.cbAutoSaveConfig.Size = new System.Drawing.Size(274, 24);
            this.cbAutoSaveConfig.TabIndex = 1;
            this.cbAutoSaveConfig.Text = "Save the configuration automatically";
            this.cbAutoSaveConfig.UseVisualStyleBackColor = true;
            // 
            // cbWiredOnly
            // 
            this.cbWiredOnly.AutoSize = true;
            this.cbWiredOnly.Location = new System.Drawing.Point(10, 10);
            this.cbWiredOnly.Name = "cbWiredOnly";
            this.cbWiredOnly.Size = new System.Drawing.Size(175, 24);
            this.cbWiredOnly.TabIndex = 0;
            this.cbWiredOnly.Text = "Check wired LAN only";
            this.cbWiredOnly.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 244);
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
            this.pnlConfig.PerformLayout();
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
        private System.Windows.Forms.CheckBox cbAutoSaveConfig;
        private System.Windows.Forms.CheckBox cbWiredOnly;
        private System.Windows.Forms.Label lblMailTo;
        private System.Windows.Forms.TextBox tbMailTo;
        private System.Windows.Forms.Button btSave;
    }
}

