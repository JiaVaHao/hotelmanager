using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using HotelManagerSystem.DAL;
using HotelManagerSystem.Model;
using HotelManagerSystem.BLL;

namespace HotelManagerSystem
{
    public partial class FrmReserManager : Form
    {

        public static string name;
        public static string tel;

        public FrmReserManager()
        {
            InitializeComponent();
            #region 防止背景闪屏方法
            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲 
            #endregion
        }

        public void CmpSetDgv()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBou.AllowUserToAddRows = false;
            this.dgvBou.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvBou.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBou.BackgroundColor = System.Drawing.Color.White;
            this.dgvBou.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBou.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvBou.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBou.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBou.EnableHeadersVisualStyles = false;
            this.dgvBou.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvBou.ReadOnly = true;
            this.dgvBou.RowHeadersVisible = false;
            this.dgvBou.RowTemplate.Height = 23;
            this.dgvBou.RowTemplate.ReadOnly = true;
        }

        private void FrmRoomManager_Load_1(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“hotelmanagerDataSet.roomtype”中。您可以根据需要移动或删除它。
            this.roomtypeTableAdapter.Fill(this.hotelmanagerDataSet.roomtype);
            CmpSetDgv();
            cboReserWay.SelectedIndex = 0;
            cboRoomType.SelectedIndex = 0;
            dgvBou.DataSource = ReserDao.SelectReserAll();
        }

        #region DataGridView点击数据加载到控件上
        private void dgvBou_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtReserNo.Text = dgvBou.SelectedRows[0].Cells["clReserId"].Value.ToString();
            txtCustoName.Text = dgvBou.SelectedRows[0].Cells["clCustoName"].Value.ToString();
            txtCustoTel.Text = dgvBou.SelectedRows[0].Cells["clCustoTel"].Value.ToString();
            cboReserWay.Text = dgvBou.SelectedRows[0].Cells["clReserWay"].Value.ToString();
            cboRoomType.Text = dgvBou.SelectedRows[0].Cells["clReserRoom"].Value.ToString();
            ReserCash.Text = dgvBou.SelectedRows[0].Cells["clReserCash"].Value.ToString();
            dtpBouDate.Text = dgvBou.SelectedRows[0].Cells["clReserDate"].Value.ToString();
            txtReserNum.Text = dgvBou.SelectedRows[0].Cells["clReserPerson"].Value.ToString();        
        }
        #endregion
        
        private void picUpdate_Click(object sender, EventArgs e)
        {
            if (txtReserNo.Text == "")
            {
                MessageBox.Show("还没选择预约客户信息，无法进行修改！");
            }
            else
            {
                int n = 0;
                string sql = "update reser set CustoName='" + txtCustoName.Text + "',CustoTel='" + txtCustoTel.Text + "',ReserWay='" + cboReserWay.Text + "',ReserRoom='" + cboRoomType.Text + "',ReserCash='" + ReserCash.Text + "',ReserDate='" + dtpBouDate.Value.ToShortDateString() + "',ReserPerson='" + txtReserNum.Text + "' where ReserId='" + txtReserNo.Text + "'";
                MySqlConnection con = DBHelper.GetConnection();
                n = DBHelper.ExecuteNonQuery(sql);
                MessageBox.Show("修改预约信息成功");
                dgvBou.DataSource = ReserDao.SelectReserAll();
            }
        }

        private void picAddReserInfo_Click(object sender, EventArgs e)
        {
            if (txtReserNo.Text == "")
            {
                MessageBox.Show("未输入预约编号，无法进行添加！");
            }
            else
            {
                int n = 0;
                string sql = "insert into reser values('" + txtReserNo.Text + "','" + txtCustoName.Text + "','" + txtCustoTel.Text + "','" + cboReserWay.Text + "','" + cboRoomType.Text + "','" + ReserCash.Text + "','" + dtpBouDate.Value + "','" + txtReserNum.Text + "')";
                MySqlConnection con = DBHelper.GetConnection();
                n = DBHelper.ExecuteNonQuery(sql);
                MessageBox.Show("添加预约信息成功");
                dgvBou.DataSource = ReserDao.SelectReserAll();
                txtReserNo.Text = "";
                txtCustoName.Text = "";
                txtCustoTel.Text = "";
                cboReserWay.Text = "";
                cboRoomType.Text = "";
                ReserCash.Text = "";
                dtpBouDate.Text = "";
                txtReserNum.Text = "";
            }

        }

        private void picDeleteReser_Click(object sender, EventArgs e)
        {
            if (txtReserNo.Text != "")
            {
                string sql = "delete from reser where ReserId='" + txtReserNo.Text + "'";
                MySqlConnection con = DBHelper.GetConnection();
                int n = DBHelper.ExecuteNonQuery(sql);
                if (n > 0)
                {
                    MessageBox.Show("删除预约信息成功", "删除提示");
                    txtReserNo.Text = "";
                    dgvBou.DataSource = ReserDao.SelectReserAll();
                }
                else
                {
                    MessageBox.Show("删除预约信息失败", "错误提示");
                }
            }
            else
            {
                MessageBox.Show("请输入要删除的预约编号！", "提醒");
            }
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            if(txtCustoTel.Text=="")
            {
                dgvBou.DataSource = ReserDao.SelectReserAll();
            }
            else
            {
                string tel = txtCustoTel.Text;
                dgvBou.DataSource = ReserDao.SelectReserInfoByConn(tel);
            }
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvBou_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgvBou.Columns["movein"].Index)
            {
                if (MessageBox.Show("确定要给此客户办理入住吗？", "重要提示！", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.OK)
                {
                    int rows = dgvBou.CurrentRow.Index; //得到当前行的索引
                    name = dgvBou.Rows[rows].Cells[1].Value.ToString();
                    tel = dgvBou.Rows[rows].Cells[2].Value.ToString();
                }
            }
        }
    }
}