namespace HotelManagerSystem
{
    partial class FrmCheckIn
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
            this.btnClose = new System.Windows.Forms.Button();
            this.txtCheckNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomPosition = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCustoNo = new System.Windows.Forms.TextBox();
            this.txtPersonNum = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.roomtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelmanagerDataSet = new HotelManagerSystem.hotelmanagerDataSet();
            this.txtState = new System.Windows.Forms.ComboBox();
            this.roomstateBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.roomstateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roomstateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomstateTableAdapter = new HotelManagerSystem.hotelmanagerDataSetTableAdapters.roomstateTableAdapter();
            this.roomtypeTableAdapter = new HotelManagerSystem.hotelmanagerDataSetTableAdapters.roomtypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmanagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomstateBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomstateBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomstateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(309, 296);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 29);
            this.btnClose.TabIndex = 103;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCheckNum
            // 
            this.txtCheckNum.Location = new System.Drawing.Point(417, 132);
            this.txtCheckNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheckNum.Name = "txtCheckNum";
            this.txtCheckNum.Size = new System.Drawing.Size(119, 25);
            this.txtCheckNum.TabIndex = 102;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 101;
            this.label3.Text = "入住天数";
            // 
            // txtRoomPosition
            // 
            this.txtRoomPosition.Location = new System.Drawing.Point(417, 241);
            this.txtRoomPosition.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomPosition.Name = "txtRoomPosition";
            this.txtRoomPosition.ReadOnly = true;
            this.txtRoomPosition.Size = new System.Drawing.Size(119, 25);
            this.txtRoomPosition.TabIndex = 98;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(344, 81);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 15);
            this.label17.TabIndex = 99;
            this.label17.Text = "客户编号";
            // 
            // txtCustoNo
            // 
            this.txtCustoNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustoNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustoNo.Location = new System.Drawing.Point(417, 78);
            this.txtCustoNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustoNo.MaxLength = 6;
            this.txtCustoNo.Name = "txtCustoNo";
            this.txtCustoNo.Size = new System.Drawing.Size(119, 25);
            this.txtCustoNo.TabIndex = 100;
            // 
            // txtPersonNum
            // 
            this.txtPersonNum.Location = new System.Drawing.Point(417, 188);
            this.txtPersonNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonNum.Name = "txtPersonNum";
            this.txtPersonNum.Size = new System.Drawing.Size(119, 25);
            this.txtPersonNum.TabIndex = 97;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(101, 241);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(113, 25);
            this.txtMoney.TabIndex = 96;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtRoomNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRoomNo.Location = new System.Drawing.Point(101, 75);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(113, 25);
            this.txtRoomNo.TabIndex = 92;
            this.txtRoomNo.TextChanged += new System.EventHandler(this.txtRoomNo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 91;
            this.label8.Text = "房间位置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 90;
            this.label7.Text = "房间人数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 89;
            this.label6.Text = "房间单价";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 88;
            this.label5.Text = "房间状态";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 86;
            this.label2.Text = "房间类型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 85;
            this.label1.Text = "房间编号";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Location = new System.Drawing.Point(152, 296);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(100, 29);
            this.btnCheckIn.TabIndex = 104;
            this.btnCheckIn.Text = "入住";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("隶书", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(192, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 37);
            this.label4.TabIndex = 107;
            this.label4.Text = "房间入住";
            // 
            // txtType
            // 
            this.txtType.FormattingEnabled = true;
            this.txtType.Location = new System.Drawing.Point(101, 134);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(113, 23);
            this.txtType.TabIndex = 108;
            // 
            // roomtypeBindingSource
            // 
            this.roomtypeBindingSource.DataMember = "roomtype";
            this.roomtypeBindingSource.DataSource = this.hotelmanagerDataSet;
            // 
            // hotelmanagerDataSet
            // 
            this.hotelmanagerDataSet.DataSetName = "hotelmanagerDataSet";
            this.hotelmanagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtState
            // 
            this.txtState.FormattingEnabled = true;
            this.txtState.Location = new System.Drawing.Point(101, 191);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(113, 23);
            this.txtState.TabIndex = 109;
            // 
            // roomstateBindingSource2
            // 
            this.roomstateBindingSource2.DataMember = "roomstate";
            this.roomstateBindingSource2.DataSource = this.hotelmanagerDataSet;
            // 
            // roomstateBindingSource1
            // 
            this.roomstateBindingSource1.DataMember = "roomstate";
            this.roomstateBindingSource1.DataSource = this.hotelmanagerDataSet;
            // 
            // roomstateBindingSource
            // 
            this.roomstateBindingSource.DataMember = "roomstate";
            this.roomstateBindingSource.DataSource = this.hotelmanagerDataSet;
            // 
            // roomstateTableAdapter
            // 
            this.roomstateTableAdapter.ClearBeforeFill = true;
            // 
            // roomtypeTableAdapter
            // 
            this.roomtypeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(560, 350);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtCheckNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRoomPosition);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtCustoNo);
            this.Controls.Add(this.txtPersonNum);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TS酒店管理系统房间入住";
            this.Load += new System.EventHandler(this.FrmCheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmanagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomstateBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomstateBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomstateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtCheckNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoomPosition;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCustoNo;
        private System.Windows.Forms.TextBox txtPersonNum;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.ComboBox txtState;
        private HotelManagerSystem.hotelmanagerDataSet hotelmanagerDataSet;
        private System.Windows.Forms.BindingSource roomstateBindingSource;
        private HotelManagerSystem.hotelmanagerDataSetTableAdapters.roomstateTableAdapter roomstateTableAdapter;
        private System.Windows.Forms.BindingSource roomstateBindingSource1;
        private System.Windows.Forms.BindingSource roomtypeBindingSource;
        private HotelManagerSystem.hotelmanagerDataSetTableAdapters.roomtypeTableAdapter roomtypeTableAdapter;
        private System.Windows.Forms.BindingSource roomstateBindingSource2;
    }
}