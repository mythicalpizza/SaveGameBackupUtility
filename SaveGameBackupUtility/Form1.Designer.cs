namespace SaveGameBackupUtility
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnInitBackup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBackupDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaveGameDir = new System.Windows.Forms.TextBox();
            this.btnBackupDirBrowse = new System.Windows.Forms.Button();
            this.btnSaveDirBrowse = new System.Windows.Forms.Button();
            this.helpLinkBackupDir = new System.Windows.Forms.LinkLabel();
            this.helpLinkSaveDir = new System.Windows.Forms.LinkLabel();
            this.pathGroup = new System.Windows.Forms.GroupBox();
            this.gameList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkremoveAfterBackup = new System.Windows.Forms.CheckBox();
            this.configGroup = new System.Windows.Forms.GroupBox();
            this.pgbCompletionStatus = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsGroup = new System.Windows.Forms.GroupBox();
            this.chkIgnoreSubFolders = new System.Windows.Forms.CheckBox();
            this.pathGroup.SuspendLayout();
            this.configGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.optionsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnInitBackup
            // 
            this.btnInitBackup.Location = new System.Drawing.Point(12, 360);
            this.btnInitBackup.Name = "btnInitBackup";
            this.btnInitBackup.Size = new System.Drawing.Size(130, 23);
            this.btnInitBackup.TabIndex = 15;
            this.btnInitBackup.Text = "Backup Selected Files";
            this.btnInitBackup.UseVisualStyleBackColor = true;
            this.btnInitBackup.Click += new System.EventHandler(this.btnInitBackup_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Backup Directory";
            // 
            // txtBackupDir
            // 
            this.txtBackupDir.Location = new System.Drawing.Point(9, 32);
            this.txtBackupDir.Name = "txtBackupDir";
            this.txtBackupDir.Size = new System.Drawing.Size(398, 20);
            this.txtBackupDir.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Save File Directory";
            // 
            // txtSaveGameDir
            // 
            this.txtSaveGameDir.Location = new System.Drawing.Point(9, 94);
            this.txtSaveGameDir.Name = "txtSaveGameDir";
            this.txtSaveGameDir.Size = new System.Drawing.Size(398, 20);
            this.txtSaveGameDir.TabIndex = 12;
            // 
            // btnBackupDirBrowse
            // 
            this.btnBackupDirBrowse.Location = new System.Drawing.Point(413, 30);
            this.btnBackupDirBrowse.Name = "btnBackupDirBrowse";
            this.btnBackupDirBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBackupDirBrowse.TabIndex = 13;
            this.btnBackupDirBrowse.Text = "Browse";
            this.btnBackupDirBrowse.UseVisualStyleBackColor = true;
            this.btnBackupDirBrowse.Click += new System.EventHandler(this.btnBackupDirBrowse_Click_1);
            // 
            // btnSaveDirBrowse
            // 
            this.btnSaveDirBrowse.Location = new System.Drawing.Point(413, 92);
            this.btnSaveDirBrowse.Name = "btnSaveDirBrowse";
            this.btnSaveDirBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDirBrowse.TabIndex = 14;
            this.btnSaveDirBrowse.Text = "Browse";
            this.btnSaveDirBrowse.UseVisualStyleBackColor = true;
            this.btnSaveDirBrowse.Click += new System.EventHandler(this.btnSaveDirBrowse_Click_1);
            // 
            // helpLinkBackupDir
            // 
            this.helpLinkBackupDir.AutoSize = true;
            this.helpLinkBackupDir.Location = new System.Drawing.Point(97, 16);
            this.helpLinkBackupDir.Name = "helpLinkBackupDir";
            this.helpLinkBackupDir.Size = new System.Drawing.Size(69, 13);
            this.helpLinkBackupDir.TabIndex = 16;
            this.helpLinkBackupDir.TabStop = true;
            this.helpLinkBackupDir.Text = "What\'s This?";
            this.helpLinkBackupDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helpLinkBackupDir_LinkClicked);
            // 
            // helpLinkSaveDir
            // 
            this.helpLinkSaveDir.AutoSize = true;
            this.helpLinkSaveDir.Location = new System.Drawing.Point(111, 77);
            this.helpLinkSaveDir.Name = "helpLinkSaveDir";
            this.helpLinkSaveDir.Size = new System.Drawing.Size(69, 13);
            this.helpLinkSaveDir.TabIndex = 17;
            this.helpLinkSaveDir.TabStop = true;
            this.helpLinkSaveDir.Text = "What\'s This?";
            this.helpLinkSaveDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helpLinkSaveDir_LinkClicked);
            // 
            // pathGroup
            // 
            this.pathGroup.Controls.Add(this.helpLinkSaveDir);
            this.pathGroup.Controls.Add(this.helpLinkBackupDir);
            this.pathGroup.Controls.Add(this.btnSaveDirBrowse);
            this.pathGroup.Controls.Add(this.btnBackupDirBrowse);
            this.pathGroup.Controls.Add(this.txtSaveGameDir);
            this.pathGroup.Controls.Add(this.label2);
            this.pathGroup.Controls.Add(this.txtBackupDir);
            this.pathGroup.Controls.Add(this.label1);
            this.pathGroup.Location = new System.Drawing.Point(12, 91);
            this.pathGroup.Name = "pathGroup";
            this.pathGroup.Size = new System.Drawing.Size(505, 123);
            this.pathGroup.TabIndex = 9;
            this.pathGroup.TabStop = false;
            this.pathGroup.Text = "Select Paths";
            // 
            // gameList
            // 
            this.gameList.FormattingEnabled = true;
            this.gameList.Location = new System.Drawing.Point(48, 17);
            this.gameList.Name = "gameList";
            this.gameList.Size = new System.Drawing.Size(121, 21);
            this.gameList.TabIndex = 10;
            this.gameList.SelectedIndexChanged += new System.EventHandler(this.gameList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Game";
            // 
            // chkremoveAfterBackup
            // 
            this.chkremoveAfterBackup.AutoSize = true;
            this.chkremoveAfterBackup.Location = new System.Drawing.Point(176, 19);
            this.chkremoveAfterBackup.Name = "chkremoveAfterBackup";
            this.chkremoveAfterBackup.Size = new System.Drawing.Size(167, 17);
            this.chkremoveAfterBackup.TabIndex = 12;
            this.chkremoveAfterBackup.Text = "Remove preset (after backup)";
            this.chkremoveAfterBackup.UseVisualStyleBackColor = true;
            this.chkremoveAfterBackup.CheckedChanged += new System.EventHandler(this.chkremoveAfterBackup_CheckedChanged);
            // 
            // configGroup
            // 
            this.configGroup.Controls.Add(this.chkremoveAfterBackup);
            this.configGroup.Controls.Add(this.label3);
            this.configGroup.Controls.Add(this.gameList);
            this.configGroup.Location = new System.Drawing.Point(12, 27);
            this.configGroup.Name = "configGroup";
            this.configGroup.Size = new System.Drawing.Size(505, 58);
            this.configGroup.TabIndex = 11;
            this.configGroup.TabStop = false;
            this.configGroup.Text = "Config";
            this.configGroup.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pgbCompletionStatus
            // 
            this.pgbCompletionStatus.Location = new System.Drawing.Point(148, 360);
            this.pgbCompletionStatus.Name = "pgbCompletionStatus";
            this.pgbCompletionStatus.Size = new System.Drawing.Size(369, 23);
            this.pgbCompletionStatus.TabIndex = 16;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 392);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(60, 13);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status: Idle";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // optionsGroup
            // 
            this.optionsGroup.Controls.Add(this.chkIgnoreSubFolders);
            this.optionsGroup.Location = new System.Drawing.Point(15, 232);
            this.optionsGroup.Name = "optionsGroup";
            this.optionsGroup.Size = new System.Drawing.Size(502, 100);
            this.optionsGroup.TabIndex = 19;
            this.optionsGroup.TabStop = false;
            this.optionsGroup.Text = "Options";
            // 
            // chkIgnoreSubFolders
            // 
            this.chkIgnoreSubFolders.AutoSize = true;
            this.chkIgnoreSubFolders.Location = new System.Drawing.Point(7, 20);
            this.chkIgnoreSubFolders.Name = "chkIgnoreSubFolders";
            this.chkIgnoreSubFolders.Size = new System.Drawing.Size(126, 17);
            this.chkIgnoreSubFolders.TabIndex = 0;
            this.chkIgnoreSubFolders.Text = "Ignore Subdirectories";
            this.chkIgnoreSubFolders.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 414);
            this.Controls.Add(this.optionsGroup);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pgbCompletionStatus);
            this.Controls.Add(this.configGroup);
            this.Controls.Add(this.pathGroup);
            this.Controls.Add(this.btnInitBackup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SaveGame Backup Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pathGroup.ResumeLayout(false);
            this.pathGroup.PerformLayout();
            this.configGroup.ResumeLayout(false);
            this.configGroup.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.optionsGroup.ResumeLayout(false);
            this.optionsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnInitBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBackupDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaveGameDir;
        private System.Windows.Forms.Button btnBackupDirBrowse;
        private System.Windows.Forms.Button btnSaveDirBrowse;
        private System.Windows.Forms.LinkLabel helpLinkBackupDir;
        private System.Windows.Forms.LinkLabel helpLinkSaveDir;
        private System.Windows.Forms.GroupBox pathGroup;
        private System.Windows.Forms.ComboBox gameList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkremoveAfterBackup;
        private System.Windows.Forms.GroupBox configGroup;
        private System.Windows.Forms.ProgressBar pgbCompletionStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox optionsGroup;
        private System.Windows.Forms.CheckBox chkIgnoreSubFolders;
    }
}

