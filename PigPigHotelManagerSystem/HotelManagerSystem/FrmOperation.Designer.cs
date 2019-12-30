namespace HotelManagerSystem
{
    partial class FrmOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOperation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOperationlog = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabOperation = new System.Windows.Forms.TabControl();
            this.loginOperation = new System.Windows.Forms.TabPage();
            this.spendOperation = new System.Windows.Forms.TabPage();
            this.spOperationlog = new System.Windows.Forms.DataGridView();
            this.spendClear = new System.Windows.Forms.Button();
            this.SpendId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpendDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OperationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOperationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOperationLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOperationAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperationlog)).BeginInit();
            this.tabOperation.SuspendLayout();
            this.loginOperation.SuspendLayout();
            this.spendOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spOperationlog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOperationlog
            // 
            this.dgvOperationlog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOperationlog.BackgroundColor = System.Drawing.Color.White;
            this.dgvOperationlog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperationlog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OperationId,
            this.clOperationTime,
            this.clOperationLog,
            this.clOperationAccount,
            this.columnDelete});
            this.dgvOperationlog.Location = new System.Drawing.Point(6, 7);
            this.dgvOperationlog.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOperationlog.Name = "dgvOperationlog";
            this.dgvOperationlog.RowTemplate.Height = 23;
            this.dgvOperationlog.Size = new System.Drawing.Size(1287, 473);
            this.dgvOperationlog.TabIndex = 0;
            this.dgvOperationlog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOperationlog_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(1191, 486);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 29);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tabOperation
            // 
            this.tabOperation.Controls.Add(this.loginOperation);
            this.tabOperation.Controls.Add(this.spendOperation);
            this.tabOperation.Location = new System.Drawing.Point(7, 5);
            this.tabOperation.Name = "tabOperation";
            this.tabOperation.SelectedIndex = 0;
            this.tabOperation.Size = new System.Drawing.Size(1308, 553);
            this.tabOperation.TabIndex = 5;
            this.tabOperation.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // loginOperation
            // 
            this.loginOperation.BackColor = System.Drawing.Color.SkyBlue;
            this.loginOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginOperation.Controls.Add(this.dgvOperationlog);
            this.loginOperation.Controls.Add(this.btnClear);
            this.loginOperation.Location = new System.Drawing.Point(4, 25);
            this.loginOperation.Name = "loginOperation";
            this.loginOperation.Padding = new System.Windows.Forms.Padding(3);
            this.loginOperation.Size = new System.Drawing.Size(1300, 524);
            this.loginOperation.TabIndex = 0;
            this.loginOperation.Text = "登录日志";
            // 
            // spendOperation
            // 
            this.spendOperation.BackColor = System.Drawing.Color.SkyBlue;
            this.spendOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spendOperation.Controls.Add(this.spOperationlog);
            this.spendOperation.Controls.Add(this.spendClear);
            this.spendOperation.Location = new System.Drawing.Point(4, 25);
            this.spendOperation.Name = "spendOperation";
            this.spendOperation.Padding = new System.Windows.Forms.Padding(3);
            this.spendOperation.Size = new System.Drawing.Size(1300, 524);
            this.spendOperation.TabIndex = 1;
            this.spendOperation.Text = "退房日志";
            // 
            // spOperationlog
            // 
            this.spOperationlog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.spOperationlog.BackgroundColor = System.Drawing.Color.White;
            this.spOperationlog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spOperationlog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpendId,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.SpendDelete});
            this.spOperationlog.Location = new System.Drawing.Point(6, 7);
            this.spOperationlog.Margin = new System.Windows.Forms.Padding(4);
            this.spOperationlog.Name = "spOperationlog";
            this.spOperationlog.RowTemplate.Height = 23;
            this.spOperationlog.Size = new System.Drawing.Size(1287, 473);
            this.spOperationlog.TabIndex = 5;
            this.spOperationlog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.spOperation_CellContentClick);
            // 
            // spendClear
            // 
            this.spendClear.BackColor = System.Drawing.Color.SkyBlue;
            this.spendClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spendClear.BackgroundImage")));
            this.spendClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spendClear.FlatAppearance.BorderSize = 0;
            this.spendClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spendClear.Location = new System.Drawing.Point(1191, 486);
            this.spendClear.Margin = new System.Windows.Forms.Padding(4);
            this.spendClear.Name = "spendClear";
            this.spendClear.Size = new System.Drawing.Size(100, 29);
            this.spendClear.TabIndex = 6;
            this.spendClear.Text = "清空";
            this.spendClear.UseVisualStyleBackColor = false;
            this.spendClear.Click += new System.EventHandler(this.spendClear_Click);
            // 
            // SpendId
            // 
            this.SpendId.DataPropertyName = "SpendId";
            this.SpendId.FillWeight = 40F;
            this.SpendId.HeaderText = "支付编号";
            this.SpendId.Name = "SpendId";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RoomNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "房间编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustoNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "客户编号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SpendMoney";
            this.dataGridViewTextBoxColumn3.HeaderText = "支付金额";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SpendTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "支付时间";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // SpendDelete
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpendDelete.DefaultCellStyle = dataGridViewCellStyle5;
            this.SpendDelete.FillWeight = 30F;
            this.SpendDelete.HeaderText = "删除";
            this.SpendDelete.Name = "SpendDelete";
            this.SpendDelete.Text = "删除";
            this.SpendDelete.UseColumnTextForButtonValue = true;
            // 
            // OperationId
            // 
            this.OperationId.DataPropertyName = "OperationId";
            this.OperationId.FillWeight = 25F;
            this.OperationId.HeaderText = "日志编号";
            this.OperationId.Name = "OperationId";
            // 
            // clOperationTime
            // 
            this.clOperationTime.DataPropertyName = "OperationTime";
            this.clOperationTime.HeaderText = "操作时间";
            this.clOperationTime.Name = "clOperationTime";
            // 
            // clOperationLog
            // 
            this.clOperationLog.DataPropertyName = "OperationLog";
            this.clOperationLog.HeaderText = "日志详情";
            this.clOperationLog.Name = "clOperationLog";
            // 
            // clOperationAccount
            // 
            this.clOperationAccount.DataPropertyName = "OperationAccount";
            this.clOperationAccount.FillWeight = 30F;
            this.clOperationAccount.HeaderText = "操作账号";
            this.clOperationAccount.Name = "clOperationAccount";
            // 
            // columnDelete
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.columnDelete.DefaultCellStyle = dataGridViewCellStyle6;
            this.columnDelete.FillWeight = 18F;
            this.columnDelete.HeaderText = "删除";
            this.columnDelete.Name = "columnDelete";
            this.columnDelete.Text = "删除";
            this.columnDelete.UseColumnTextForButtonValue = true;
            // 
            // FrmOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1319, 570);
            this.Controls.Add(this.tabOperation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOperation";
            this.Text = "FrmOperation";
            this.Load += new System.EventHandler(this.FrmOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperationlog)).EndInit();
            this.tabOperation.ResumeLayout(false);
            this.loginOperation.ResumeLayout(false);
            this.spendOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spOperationlog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOperationlog;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabControl tabOperation;
        private System.Windows.Forms.TabPage loginOperation;
        private System.Windows.Forms.TabPage spendOperation;
        private System.Windows.Forms.DataGridView spOperationlog;
        private System.Windows.Forms.Button spendClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpendId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn SpendDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOperationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOperationLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOperationAccount;
        private System.Windows.Forms.DataGridViewButtonColumn columnDelete;
    }
}