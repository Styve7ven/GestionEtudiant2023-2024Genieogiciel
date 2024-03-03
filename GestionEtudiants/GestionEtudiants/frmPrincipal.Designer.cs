namespace GestionEtudiants
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.stStatus = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tblConnection = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tblPreview = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.smConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.smDisconnection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.smCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.smExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnData = new System.Windows.Forms.ToolStripMenuItem();
            this.smPersons = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.smListPersons = new System.Windows.Forms.ToolStripMenuItem();
            this.mnParameters = new System.Windows.Forms.ToolStripMenuItem();
            this.smToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.smStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.smAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.stStatus.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // stStatus
            // 
            this.stStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.stStatus.Location = new System.Drawing.Point(0, 534);
            this.stStatus.Name = "stStatus";
            this.stStatus.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.stStatus.Size = new System.Drawing.Size(1264, 25);
            this.stStatus.TabIndex = 5;
            this.stStatus.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(157, 20);
            this.lblStatus.Text = "Gestion des personnes";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tblConnection,
            this.toolStripSeparator1,
            this.tblPreview,
            this.toolStripSeparator2});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1264, 27);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "ToolStrip";
            // 
            // tblConnection
            // 
            this.tblConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblConnection.Image = ((System.Drawing.Image)(resources.GetObject("tblConnection.Image")));
            this.tblConnection.ImageTransparentColor = System.Drawing.Color.Black;
            this.tblConnection.Name = "tblConnection";
            this.tblConnection.Size = new System.Drawing.Size(24, 24);
            this.tblConnection.Text = "New";
            this.tblConnection.Click += new System.EventHandler(this.tblConnection_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tblPreview
            // 
            this.tblPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblPreview.Image = ((System.Drawing.Image)(resources.GetObject("tblPreview.Image")));
            this.tblPreview.ImageTransparentColor = System.Drawing.Color.Black;
            this.tblPreview.Name = "tblPreview";
            this.tblPreview.Size = new System.Drawing.Size(24, 24);
            this.tblPreview.Text = "Print Preview";
            this.tblPreview.Click += new System.EventHandler(this.tblPreview_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFile,
            this.mnData,
            this.mnParameters,
            this.mnHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1264, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnFile
            // 
            this.mnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smConnection,
            this.smDisconnection,
            this.toolStripSeparator3,
            this.smCloseAll,
            this.toolStripSeparator4,
            this.smExit});
            this.mnFile.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnFile.Name = "mnFile";
            this.mnFile.Size = new System.Drawing.Size(64, 24);
            this.mnFile.Text = "&Fichier";
            // 
            // smConnection
            // 
            this.smConnection.Image = ((System.Drawing.Image)(resources.GetObject("smConnection.Image")));
            this.smConnection.ImageTransparentColor = System.Drawing.Color.Black;
            this.smConnection.Name = "smConnection";
            this.smConnection.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.N)));
            this.smConnection.Size = new System.Drawing.Size(253, 26);
            this.smConnection.Text = "&Connexion";
            this.smConnection.Click += new System.EventHandler(this.smConnection_Click);
            // 
            // smDisconnection
            // 
            this.smDisconnection.Image = ((System.Drawing.Image)(resources.GetObject("smDisconnection.Image")));
            this.smDisconnection.ImageTransparentColor = System.Drawing.Color.Black;
            this.smDisconnection.Name = "smDisconnection";
            this.smDisconnection.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D)));
            this.smDisconnection.Size = new System.Drawing.Size(253, 26);
            this.smDisconnection.Text = "&Déconnexion";
            this.smDisconnection.Click += new System.EventHandler(this.smDisconnection_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(250, 6);
            // 
            // smCloseAll
            // 
            this.smCloseAll.Name = "smCloseAll";
            this.smCloseAll.Size = new System.Drawing.Size(253, 26);
            this.smCloseAll.Text = "Fermer Tous";
            this.smCloseAll.Click += new System.EventHandler(this.smCloseAll_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(250, 6);
            // 
            // smExit
            // 
            this.smExit.Name = "smExit";
            this.smExit.Size = new System.Drawing.Size(253, 26);
            this.smExit.Text = "&Quitter";
            this.smExit.Click += new System.EventHandler(this.smExit_Click);
            // 
            // mnData
            // 
            this.mnData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smPersons,
            this.toolStripSeparator6,
            this.smListPersons});
            this.mnData.Name = "mnData";
            this.mnData.Size = new System.Drawing.Size(79, 24);
            this.mnData.Text = "&Données";
            // 
            // smPersons
            // 
            this.smPersons.Image = ((System.Drawing.Image)(resources.GetObject("smPersons.Image")));
            this.smPersons.ImageTransparentColor = System.Drawing.Color.Black;
            this.smPersons.Name = "smPersons";
            this.smPersons.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.P)));
            this.smPersons.Size = new System.Drawing.Size(302, 26);
            this.smPersons.Text = "&Personnes";
            this.smPersons.Click += new System.EventHandler(this.smPersons_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(299, 6);
            // 
            // smListPersons
            // 
            this.smListPersons.Image = ((System.Drawing.Image)(resources.GetObject("smListPersons.Image")));
            this.smListPersons.Name = "smListPersons";
            this.smListPersons.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.smListPersons.Size = new System.Drawing.Size(302, 26);
            this.smListPersons.Text = "Liste des personnes";
            this.smListPersons.Click += new System.EventHandler(this.smListPersons_Click);
            // 
            // mnParameters
            // 
            this.mnParameters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smToolbar,
            this.smStatusBar});
            this.mnParameters.Name = "mnParameters";
            this.mnParameters.Size = new System.Drawing.Size(94, 24);
            this.mnParameters.Text = "&Paramètres";
            // 
            // smToolbar
            // 
            this.smToolbar.Checked = true;
            this.smToolbar.CheckOnClick = true;
            this.smToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smToolbar.Name = "smToolbar";
            this.smToolbar.Size = new System.Drawing.Size(181, 26);
            this.smToolbar.Text = "&Barre d\'outil";
            this.smToolbar.Click += new System.EventHandler(this.smToolbar_Click);
            // 
            // smStatusBar
            // 
            this.smStatusBar.Checked = true;
            this.smStatusBar.CheckOnClick = true;
            this.smStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smStatusBar.Name = "smStatusBar";
            this.smStatusBar.Size = new System.Drawing.Size(181, 26);
            this.smStatusBar.Text = "Barre d\'ét&at";
            this.smStatusBar.Click += new System.EventHandler(this.smStatusBar_Click);
            // 
            // mnHelp
            // 
            this.mnHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smAbout});
            this.mnHelp.Name = "mnHelp";
            this.mnHelp.Size = new System.Drawing.Size(52, 24);
            this.mnHelp.Text = "Aid&e";
            // 
            // smAbout
            // 
            this.smAbout.Name = "smAbout";
            this.smAbout.Size = new System.Drawing.Size(181, 26);
            this.smAbout.Text = "&A Propos ... ...";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 559);
            this.Controls.Add(this.stStatus);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Name = "frmPrincipal";
            this.Text = "Interface principale de gestion des personnes";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.stStatus.ResumeLayout(false);
            this.stStatus.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tblConnection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tblPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnFile;
        private System.Windows.Forms.ToolStripMenuItem smConnection;
        private System.Windows.Forms.ToolStripMenuItem smDisconnection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem smCloseAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem smExit;
        private System.Windows.Forms.ToolStripMenuItem mnData;
        private System.Windows.Forms.ToolStripMenuItem smPersons;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem smListPersons;
        private System.Windows.Forms.ToolStripMenuItem mnParameters;
        private System.Windows.Forms.ToolStripMenuItem smToolbar;
        private System.Windows.Forms.ToolStripMenuItem smStatusBar;
        private System.Windows.Forms.ToolStripMenuItem mnHelp;
        private System.Windows.Forms.ToolStripMenuItem smAbout;
        private System.Windows.Forms.ToolTip toolTip;
    }
}