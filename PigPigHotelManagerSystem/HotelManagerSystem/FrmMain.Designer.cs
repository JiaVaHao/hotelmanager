namespace HotelManagerSystem
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblTime = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tmrDate = new System.Windows.Forms.Timer(this.components);
            this.lblScroll = new System.Windows.Forms.Label();
            this.tmrFont = new System.Windows.Forms.Timer(this.components);
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picFormSize = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picRoom = new System.Windows.Forms.PictureBox();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            this.pnlMID = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiLockScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCheckUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExitSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.fadeTimer = new System.Windows.Forms.Timer(this.components);
            this.picCommodity = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.picReser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFormSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.cmsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCommodity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(461, 11);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(99, 23);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "NowTime";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserName.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserName.Location = new System.Drawing.Point(227, 14);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(227, 26);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Admin【管理员】";
            // 
            // tmrDate
            // 
            this.tmrDate.Enabled = true;
            this.tmrDate.Interval = 1000;
            this.tmrDate.Tick += new System.EventHandler(this.tmrDate_Tick);
            // 
            // lblScroll
            // 
            this.lblScroll.BackColor = System.Drawing.Color.Transparent;
            this.lblScroll.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScroll.Location = new System.Drawing.Point(-9, 6);
            this.lblScroll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScroll.Name = "lblScroll";
            this.lblScroll.Size = new System.Drawing.Size(844, 31);
            this.lblScroll.TabIndex = 0;
            this.lblScroll.Text = "欢迎使用姜猪皮酒店管理系统，若遇bug等问题请向王家丰进行反馈！";
            this.lblScroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrFont
            // 
            this.tmrFont.Enabled = true;
            this.tmrFont.Tick += new System.EventHandler(this.tmrFont_Tick);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClose.BackgroundImage")));
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Location = new System.Drawing.Point(1287, 0);
            this.picClose.Margin = new System.Windows.Forms.Padding(4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(47, 44);
            this.picClose.TabIndex = 11;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // picFormSize
            // 
            this.picFormSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picFormSize.BackColor = System.Drawing.Color.Transparent;
            this.picFormSize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFormSize.BackgroundImage")));
            this.picFormSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFormSize.Location = new System.Drawing.Point(1232, 0);
            this.picFormSize.Margin = new System.Windows.Forms.Padding(4);
            this.picFormSize.Name = "picFormSize";
            this.picFormSize.Size = new System.Drawing.Size(47, 44);
            this.picFormSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picFormSize.TabIndex = 12;
            this.picFormSize.TabStop = false;
            this.picFormSize.Click += new System.EventHandler(this.picFormSize_Click);
            this.picFormSize.MouseEnter += new System.EventHandler(this.picFormSize_MouseEnter);
            this.picFormSize.MouseLeave += new System.EventHandler(this.picFormSize_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "酒店管理系统Pro";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(46, 37);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 126);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // picRoom
            // 
            this.picRoom.BackColor = System.Drawing.Color.Transparent;
            this.picRoom.BackgroundImage = global::HotelManagerSystem.Properties.Resources.客房管理_ib;
            this.picRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRoom.Location = new System.Drawing.Point(520, 55);
            this.picRoom.Margin = new System.Windows.Forms.Padding(4);
            this.picRoom.Name = "picRoom";
            this.picRoom.Size = new System.Drawing.Size(165, 104);
            this.picRoom.TabIndex = 16;
            this.picRoom.TabStop = false;
            this.picRoom.Click += new System.EventHandler(this.picRoom_Click);
            // 
            // picCustomer
            // 
            this.picCustomer.BackColor = System.Drawing.Color.Transparent;
            this.picCustomer.BackgroundImage = global::HotelManagerSystem.Properties.Resources.用户管理_ib;
            this.picCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCustomer.Location = new System.Drawing.Point(778, 55);
            this.picCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(177, 104);
            this.picCustomer.TabIndex = 17;
            this.picCustomer.TabStop = false;
            this.picCustomer.Click += new System.EventHandler(this.picCustomer_Click);
            // 
            // pnlMID
            // 
            this.pnlMID.BackColor = System.Drawing.Color.Transparent;
            this.pnlMID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMID.Location = new System.Drawing.Point(5, 166);
            this.pnlMID.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMID.Name = "pnlMID";
            this.pnlMID.Size = new System.Drawing.Size(1325, 568);
            this.pnlMID.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblScroll);
            this.panel1.Location = new System.Drawing.Point(576, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 46);
            this.panel1.TabIndex = 24;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.cmsMain;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TS酒店管理系统";
            this.notifyIcon1.Visible = true;
            // 
            // cmsMain
            // 
            this.cmsMain.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsmiLockScreen,
            this.toolStripSeparator2,
            this.tsmiCheckUpdate,
            this.tsmiAboutUs,
            this.tsmiExitSystem});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(211, 172);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // tsmiLockScreen
            // 
            this.tsmiLockScreen.Name = "tsmiLockScreen";
            this.tsmiLockScreen.Size = new System.Drawing.Size(210, 32);
            this.tsmiLockScreen.Text = "快速锁屏";
            this.tsmiLockScreen.Click += new System.EventHandler(this.tsmiLockScreen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // tsmiCheckUpdate
            // 
            this.tsmiCheckUpdate.Name = "tsmiCheckUpdate";
            this.tsmiCheckUpdate.Size = new System.Drawing.Size(210, 32);
            this.tsmiCheckUpdate.Text = "检查更新";
            this.tsmiCheckUpdate.Click += new System.EventHandler(this.tsmiCheckUpdate_Click);
            // 
            // tsmiAboutUs
            // 
            this.tsmiAboutUs.Name = "tsmiAboutUs";
            this.tsmiAboutUs.Size = new System.Drawing.Size(210, 32);
            this.tsmiAboutUs.Text = "关于我们";
            this.tsmiAboutUs.Click += new System.EventHandler(this.tsmiAboutUs_Click);
            // 
            // tsmiExitSystem
            // 
            this.tsmiExitSystem.Name = "tsmiExitSystem";
            this.tsmiExitSystem.Size = new System.Drawing.Size(210, 32);
            this.tsmiExitSystem.Text = "退出系统";
            this.tsmiExitSystem.Click += new System.EventHandler(this.tsmiExitSystem_Click);
            // 
            // fadeTimer
            // 
            this.fadeTimer.Tick += new System.EventHandler(this.fadeTimer_Tick);
            // 
            // picCommodity
            // 
            this.picCommodity.BackColor = System.Drawing.Color.Transparent;
            this.picCommodity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCommodity.BackgroundImage")));
            this.picCommodity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCommodity.Location = new System.Drawing.Point(1047, 55);
            this.picCommodity.Margin = new System.Windows.Forms.Padding(4);
            this.picCommodity.Name = "picCommodity";
            this.picCommodity.Size = new System.Drawing.Size(145, 104);
            this.picCommodity.TabIndex = 25;
            this.picCommodity.TabStop = false;
            this.picCommodity.Click += new System.EventHandler(this.picCommodity_Click);
            // 
            // picReser
            // 
            this.picReser.BackColor = System.Drawing.Color.Transparent;
            this.picReser.BackgroundImage = global::HotelManagerSystem.Properties.Resources.预约管理;
            this.picReser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picReser.Location = new System.Drawing.Point(259, 55);
            this.picReser.Margin = new System.Windows.Forms.Padding(4);
            this.picReser.Name = "picReser";
            this.picReser.Size = new System.Drawing.Size(165, 104);
            this.picReser.TabIndex = 26;
            this.picReser.TabStop = false;
            this.picReser.Click += new System.EventHandler(this.picReser_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1333, 736);
            this.Controls.Add(this.picReser);
            this.Controls.Add(this.picCommodity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMID);
            this.Controls.Add(this.picCustomer);
            this.Controls.Add(this.picRoom);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picFormSize);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblTime);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酒店管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove_1);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFormSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.cmsMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCommodity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Timer tmrDate;
        private System.Windows.Forms.Label lblScroll;
        private System.Windows.Forms.Timer tmrFont;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picFormSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picRoom;
        private System.Windows.Forms.PictureBox picCustomer;
        private System.Windows.Forms.Panel pnlMID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiLockScreen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiExitSystem;
        private System.Windows.Forms.Timer fadeTimer;
        private System.Windows.Forms.PictureBox picCommodity;
        private System.Windows.Forms.ToolStripMenuItem tsmiAboutUs;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox picReser;
    }
}