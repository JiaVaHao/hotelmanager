namespace HotelManagerSystem
{
    partial class FrmReserManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReserManager));
            this.dgvBou = new System.Windows.Forms.DataGridView();
            this.clReserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReserWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReserRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReserCash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReserDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReserPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movein = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hotelmanagerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelmanagerDataSet = new HotelManagerSystem.hotelmanagerDataSet();
            this.picDeleteReser = new System.Windows.Forms.PictureBox();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            this.picAddReserInfo = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.ReserCash = new System.Windows.Forms.TextBox();
            this.txtReserNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.roomtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtReserNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBouDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustoName = new System.Windows.Forms.TextBox();
            this.cboReserWay = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustoTel = new System.Windows.Forms.TextBox();
            this.ttpInformation = new System.Windows.Forms.ToolTip(this.components);
            this.roomtypeTableAdapter = new HotelManagerSystem.hotelmanagerDataSetTableAdapters.roomtypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmanagerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmanagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteReser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddReserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBou
            // 
            this.dgvBou.AutoGenerateColumns = false;
            this.dgvBou.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBou.BackgroundColor = System.Drawing.Color.White;
            this.dgvBou.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBou.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clReserId,
            this.clCustoName,
            this.clCustoTel,
            this.clReserWay,
            this.clReserRoom,
            this.clReserCash,
            this.clReserDate,
            this.clReserPerson,
            this.movein});
            this.dgvBou.DataSource = this.hotelmanagerDataSetBindingSource;
            this.dgvBou.Location = new System.Drawing.Point(236, 8);
            this.dgvBou.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBou.MultiSelect = false;
            this.dgvBou.Name = "dgvBou";
            this.dgvBou.ReadOnly = true;
            this.dgvBou.RowTemplate.Height = 23;
            this.dgvBou.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBou.Size = new System.Drawing.Size(1080, 554);
            this.dgvBou.TabIndex = 13;
            this.dgvBou.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBou_CellClick);
            this.dgvBou.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBou_CellContentClick);
            // 
            // clReserId
            // 
            this.clReserId.DataPropertyName = "ReserId";
            this.clReserId.HeaderText = "预约编号";
            this.clReserId.Name = "clReserId";
            this.clReserId.ReadOnly = true;
            // 
            // clCustoName
            // 
            this.clCustoName.DataPropertyName = "CustoName";
            this.clCustoName.HeaderText = "客户姓名";
            this.clCustoName.Name = "clCustoName";
            this.clCustoName.ReadOnly = true;
            // 
            // clCustoTel
            // 
            this.clCustoTel.DataPropertyName = "CustoTel";
            this.clCustoTel.HeaderText = "预约号码";
            this.clCustoTel.Name = "clCustoTel";
            this.clCustoTel.ReadOnly = true;
            // 
            // clReserWay
            // 
            this.clReserWay.DataPropertyName = "ReserWay";
            this.clReserWay.HeaderText = "预约渠道";
            this.clReserWay.Name = "clReserWay";
            this.clReserWay.ReadOnly = true;
            // 
            // clReserRoom
            // 
            this.clReserRoom.DataPropertyName = "ReserRoom";
            this.clReserRoom.HeaderText = "房间类型";
            this.clReserRoom.Name = "clReserRoom";
            this.clReserRoom.ReadOnly = true;
            // 
            // clReserCash
            // 
            this.clReserCash.DataPropertyName = "ReserCash";
            this.clReserCash.HeaderText = "预约定金";
            this.clReserCash.Name = "clReserCash";
            this.clReserCash.ReadOnly = true;
            // 
            // clReserDate
            // 
            this.clReserDate.DataPropertyName = "ReserDate";
            this.clReserDate.HeaderText = "预约日期";
            this.clReserDate.Name = "clReserDate";
            this.clReserDate.ReadOnly = true;
            // 
            // clReserPerson
            // 
            this.clReserPerson.DataPropertyName = "ReserPerson";
            this.clReserPerson.HeaderText = "预订人数";
            this.clReserPerson.Name = "clReserPerson";
            this.clReserPerson.ReadOnly = true;
            // 
            // movein
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.movein.DefaultCellStyle = dataGridViewCellStyle1;
            this.movein.FillWeight = 60F;
            this.movein.HeaderText = "入住";
            this.movein.Name = "movein";
            this.movein.ReadOnly = true;
            this.movein.Text = "入住";
            this.movein.UseColumnTextForButtonValue = true;
            // 
            // hotelmanagerDataSetBindingSource
            // 
            this.hotelmanagerDataSetBindingSource.DataSource = this.hotelmanagerDataSet;
            this.hotelmanagerDataSetBindingSource.Position = 0;
            // 
            // hotelmanagerDataSet
            // 
            this.hotelmanagerDataSet.DataSetName = "hotelmanagerDataSet";
            this.hotelmanagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // picDeleteReser
            // 
            this.picDeleteReser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDeleteReser.BackgroundImage")));
            this.picDeleteReser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDeleteReser.Location = new System.Drawing.Point(72, 485);
            this.picDeleteReser.Margin = new System.Windows.Forms.Padding(4);
            this.picDeleteReser.Name = "picDeleteReser";
            this.picDeleteReser.Size = new System.Drawing.Size(41, 40);
            this.picDeleteReser.TabIndex = 18;
            this.picDeleteReser.TabStop = false;
            this.picDeleteReser.Click += new System.EventHandler(this.picDeleteReser_Click);
            // 
            // picUpdate
            // 
            this.picUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUpdate.BackgroundImage")));
            this.picUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUpdate.Location = new System.Drawing.Point(128, 485);
            this.picUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(41, 40);
            this.picUpdate.TabIndex = 19;
            this.picUpdate.TabStop = false;
            this.picUpdate.Click += new System.EventHandler(this.picUpdate_Click);
            // 
            // picAddReserInfo
            // 
            this.picAddReserInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAddReserInfo.BackgroundImage")));
            this.picAddReserInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAddReserInfo.Location = new System.Drawing.Point(16, 485);
            this.picAddReserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.picAddReserInfo.Name = "picAddReserInfo";
            this.picAddReserInfo.Size = new System.Drawing.Size(41, 40);
            this.picAddReserInfo.TabIndex = 20;
            this.picAddReserInfo.TabStop = false;
            this.picAddReserInfo.Click += new System.EventHandler(this.picAddReserInfo_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(185, 529);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "查询";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, 529);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "删除";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(129, 529);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "修改";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 529);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "添加";
            // 
            // picSearch
            // 
            this.picSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSearch.BackgroundImage")));
            this.picSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSearch.Location = new System.Drawing.Point(184, 485);
            this.picSearch.Margin = new System.Windows.Forms.Padding(4);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(41, 40);
            this.picSearch.TabIndex = 21;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // ReserCash
            // 
            this.ReserCash.Location = new System.Drawing.Point(95, 253);
            this.ReserCash.Margin = new System.Windows.Forms.Padding(4);
            this.ReserCash.Name = "ReserCash";
            this.ReserCash.Size = new System.Drawing.Size(132, 25);
            this.ReserCash.TabIndex = 42;
            // 
            // txtReserNo
            // 
            this.txtReserNo.Location = new System.Drawing.Point(95, 24);
            this.txtReserNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtReserNo.Name = "txtReserNo";
            this.txtReserNo.Size = new System.Drawing.Size(132, 25);
            this.txtReserNo.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 366);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "预约渠道";
            // 
            // cboRoomType
            // 
            this.cboRoomType.DataSource = this.roomtypeBindingSource;
            this.cboRoomType.DisplayMember = "RoomName";
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Location = new System.Drawing.Point(95, 307);
            this.cboRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(132, 23);
            this.cboRoomType.TabIndex = 40;
            this.cboRoomType.ValueMember = "Roomtype";
            this.cboRoomType.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // roomtypeBindingSource
            // 
            this.roomtypeBindingSource.DataMember = "roomtype";
            this.roomtypeBindingSource.DataSource = this.hotelmanagerDataSetBindingSource;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 421);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "预约日期";
            // 
            // txtReserNum
            // 
            this.txtReserNum.Location = new System.Drawing.Point(96, 193);
            this.txtReserNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtReserNum.Name = "txtReserNum";
            this.txtReserNum.Size = new System.Drawing.Size(132, 25);
            this.txtReserNum.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 311);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "房间类型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "预约编号";
            // 
            // dtpBouDate
            // 
            this.dtpBouDate.Location = new System.Drawing.Point(95, 413);
            this.dtpBouDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBouDate.Name = "dtpBouDate";
            this.dtpBouDate.Size = new System.Drawing.Size(132, 25);
            this.dtpBouDate.TabIndex = 41;
            // 
            // txtCustoName
            // 
            this.txtCustoName.Location = new System.Drawing.Point(95, 137);
            this.txtCustoName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustoName.Name = "txtCustoName";
            this.txtCustoName.Size = new System.Drawing.Size(132, 25);
            this.txtCustoName.TabIndex = 35;
            // 
            // cboReserWay
            // 
            this.cboReserWay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReserWay.FormattingEnabled = true;
            this.cboReserWay.Items.AddRange(new object[] {
            "互联网",
            "手机客户端",
            "电话"});
            this.cboReserWay.Location = new System.Drawing.Point(95, 362);
            this.cboReserWay.Margin = new System.Windows.Forms.Padding(4);
            this.cboReserWay.Name = "cboReserWay";
            this.cboReserWay.Size = new System.Drawing.Size(132, 23);
            this.cboReserWay.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "预订人数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "预约定金";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "预约号码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "客户姓名";
            // 
            // txtCustoTel
            // 
            this.txtCustoTel.Location = new System.Drawing.Point(95, 81);
            this.txtCustoTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustoTel.Name = "txtCustoTel";
            this.txtCustoTel.Size = new System.Drawing.Size(132, 25);
            this.txtCustoTel.TabIndex = 36;
            this.ttpInformation.SetToolTip(this.txtCustoTel, "请输入预约电话！");
            // 
            // roomtypeTableAdapter
            // 
            this.roomtypeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1325, 568);
            this.Controls.Add(this.ReserCash);
            this.Controls.Add(this.txtReserNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboRoomType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtReserNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBouDate);
            this.Controls.Add(this.txtCustoName);
            this.Controls.Add(this.cboReserWay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustoTel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.picAddReserInfo);
            this.Controls.Add(this.picUpdate);
            this.Controls.Add(this.picDeleteReser);
            this.Controls.Add(this.dgvBou);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReserManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客房管理";
            this.Load += new System.EventHandler(this.FrmRoomManager_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmanagerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmanagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteReser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddReserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBou;
        private System.Windows.Forms.PictureBox picDeleteReser;
        private System.Windows.Forms.PictureBox picUpdate;
        private System.Windows.Forms.PictureBox picAddReserInfo;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ReserCash;
        private System.Windows.Forms.TextBox txtReserNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReserNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBouDate;
        private System.Windows.Forms.TextBox txtCustoName;
        private System.Windows.Forms.ComboBox cboReserWay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustoTel;
        private System.Windows.Forms.ToolTip ttpInformation;
        private System.Windows.Forms.BindingSource hotelmanagerDataSetBindingSource;
        private HotelManagerSystem.hotelmanagerDataSet hotelmanagerDataSet;
        private System.Windows.Forms.BindingSource roomtypeBindingSource;
        private HotelManagerSystem.hotelmanagerDataSetTableAdapters.roomtypeTableAdapter roomtypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReserPerson;
        private System.Windows.Forms.DataGridViewButtonColumn movein;
    }
}