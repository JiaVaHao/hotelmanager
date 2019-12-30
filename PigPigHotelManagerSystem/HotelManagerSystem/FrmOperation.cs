using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagerSystem.DAL;
using MySql.Data.MySqlClient;

namespace HotelManagerSystem
{
    public partial class FrmOperation : Form
    {
        public FrmOperation()
        {
            InitializeComponent();
        }

        public void CmpSetDgv()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOperationlog.AllowUserToAddRows = false;
            this.dgvOperationlog.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvOperationlog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOperationlog.BackgroundColor = System.Drawing.Color.White;
            this.dgvOperationlog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOperationlog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvOperationlog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOperationlog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperationlog.EnableHeadersVisualStyles = false;
            this.dgvOperationlog.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvOperationlog.ReadOnly = true;
            this.dgvOperationlog.RowHeadersVisible = false;
            this.dgvOperationlog.RowTemplate.Height = 23;
            this.dgvOperationlog.RowTemplate.ReadOnly = true;
            this.spOperationlog.AllowUserToAddRows = false;
            this.spOperationlog.AllowUserToDeleteRows = false;
            this.spOperationlog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.spOperationlog.BackgroundColor = System.Drawing.Color.White;
            this.spOperationlog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spOperationlog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.spOperationlog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.spOperationlog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spOperationlog.EnableHeadersVisualStyles = false;
            this.spOperationlog.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.spOperationlog.ReadOnly = true;
            this.spOperationlog.RowHeadersVisible = false;
            this.spOperationlog.RowTemplate.Height = 23;
            this.spOperationlog.RowTemplate.ReadOnly = true;
        }

        private void FrmOperation_Load(object sender, EventArgs e)
        {
            this.Focus();
            CmpSetDgv();
            dgvOperationlog.DataSource = OperationDao.SelectOperationlogAll();
            spOperationlog.DataSource= SpendDao.SelectSpendOperation();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string sql = "delete from operationlog";
            int n = DBHelper.ExecuteNonQuery(sql);
            if (n > 0)
            {
                MessageBox.Show("删除日志成功", "删除提示");
                dgvOperationlog.DataSource = OperationDao.SelectOperationlogAll();
            }
            else
            {
                MessageBox.Show("删除日志失败", "错误提示");
            }
        }

        private void dgvOperationlog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgvOperationlog.Columns["columnDelete"].Index)
            { 
                //判断列索引是不是删除按钮
                int rows = dgvOperationlog.CurrentRow.Index; //得到当前行的索引
                int operationId = (int)(dgvOperationlog.Rows[rows].Cells[1].Value);
                if (operationId!=0 && MessageBox.Show("您确定要删除吗？", "重要提示！", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.OK)
                {
                    string sql = "delete from operationlog where OperationId='" + operationId + "'";
                    int n = DBHelper.ExecuteNonQuery(sql);
                    if (n > 0)
                    {
                        MessageBox.Show("删除日志成功", "删除提示");
                        dgvOperationlog.DataSource = OperationDao.SelectOperationlogAll();
                    }
                    else
                    {
                        MessageBox.Show("删除日志失败", "错误提示");
                    }
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabOperation.TabPages[tabOperation.SelectedIndex].Focus();
        }

        private void spOperation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.spOperationlog.Columns["SpendDelete"].Index)
            {
                //判断列索引是不是删除按钮
                int rows = spOperationlog.CurrentRow.Index; //得到当前行的索引
                int spendId = (int)(spOperationlog.Rows[rows].Cells[1].Value);
                if (spendId != 0 && MessageBox.Show("您确定要删除吗？", "重要提示！", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.OK)
                {
                    string sql = "delete from spend where SpendId='" + spendId + "'";
                    int n = DBHelper.ExecuteNonQuery(sql);
                    if (n > 0)
                    {
                        MessageBox.Show("删除日志成功", "删除提示");
                        spOperationlog.DataSource = SpendDao.SelectSpendOperation();
                    }
                    else
                    {
                        MessageBox.Show("删除日志失败", "错误提示");
                    }
                }
            }
        }

        private void spendClear_Click(object sender, EventArgs e)
        {
            string sql = "delete from spend";
            int n = DBHelper.ExecuteNonQuery(sql);
            if (n > 0)
            {
                MessageBox.Show("删除日志成功", "删除提示");
                spOperationlog.DataSource = SpendDao.SelectSpendOperation();
            }
            else
            {
                MessageBox.Show("删除日志失败", "错误提示");
            }
        }
    }
}