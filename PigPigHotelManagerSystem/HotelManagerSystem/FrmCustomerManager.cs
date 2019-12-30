using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagerSystem.BLL;
using HotelManagerSystem.DAL;
using HotelManagerSystem.Model;
using Excel = Microsoft.Office.Interop.Excel;
using HotelManagerSystem.Properties;

namespace HotelManagerSystem
{
    public partial class FrmCustomerManager : Form
    {

        public FrmCustomerManager()
        {
            InitializeComponent();
        }

        public void CmpSetDgv()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCustomerList.AllowUserToAddRows = false;
            this.dgvCustomerList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvCustomerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomerList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCustomerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 14, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCustomerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.EnableHeadersVisualStyles = false;
            this.dgvCustomerList.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvCustomerList.ReadOnly = true;
            this.dgvCustomerList.RowHeadersVisible = false;
            this.dgvCustomerList.RowTemplate.Height = 23;
            this.dgvCustomerList.RowTemplate.ReadOnly = true;
        }

        #region 用户管理界面加载事件方法
        private void FrmCustomerManager_Load(object sender, EventArgs e)
        {
            CmpSetDgv();
            dgvCustomerList.AutoGenerateColumns = false;
            LoadCustomer();
            LoadCustoType();
            txtCustoNo.ReadOnly = true;
            cboSex.SelectedIndex = 0;
            cboCustoType.SelectedIndex = 0;
            txtCustoName.Text = FrmReserManager.name;
            txtTel.Text = FrmReserManager.tel;
        }
        #endregion

        #region 加载客户类型事件方法
        public void LoadCustoType()
        {
            cboCustoType.DataSource = CustoTypeDao.SelectCustoTypesAll();
            cboCustoType.DisplayMember = "TypeName";//显示的列名
            cboCustoType.ValueMember = "UserType";//绑定的值
        }
        #endregion

        #region 加载用户信息列表
        private void LoadCustomer()
        {
            dgvCustomerList.DataSource = DAL.CustoDao.SelectCustoAll();
        }
        #endregion

        #region 点击DataGridView数据加载到控件上
        private void dgvCustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCardID.PasswordChar = Convert.ToChar("*");
            picShow.BackgroundImage = Resources.隐藏;
            txtCustoNo.Text = dgvCustomerList.SelectedRows[0].Cells["clCustoNo"].Value.ToString();
            txtCustoName.Text = dgvCustomerList.SelectedRows[0].Cells["clCustoName"].Value.ToString();
            cboSex.Text = dgvCustomerList.SelectedRows[0].Cells["clCustoSex"].Value.ToString();
            txtTel.Text = dgvCustomerList.SelectedRows[0].Cells["clCustoTel"].Value.ToString();
            cboPassport.Text = dgvCustomerList.SelectedRows[0].Cells["clPassport"].Value.ToString();
            txtCardID.Text = dgvCustomerList.SelectedRows[0].Cells["clCustoID"].Value.ToString();
            txtCustoAdress.Text = dgvCustomerList.SelectedRows[0].Cells["clCustoAdress"].Value.ToString();
            dtpBirthday.Text = dgvCustomerList.SelectedRows[0].Cells["clCustoBirth"].Value.ToString();
            cboCustoType.Text = dgvCustomerList.SelectedRows[0].Cells["clCustoType"].Value.ToString();
        }
        #endregion

        #region 添加客户信息方法
        private void picAddCusto_Click(object sender, EventArgs e)
        {
            picAddCusto.BackgroundImage = Resources.添_加_a;
            if (txtCustoNo.Text != "")
            {
                string sql = "insert userinfo(CustoNo,CustoName,CustoSex,CustoTel,PassportType,CustoID,CustoAdress,CustoBirth,CustoType)";
                sql += " values('" + txtCustoNo.Text + "','" + txtCustoName.Text + "','" + cboSex.Text + "','" + txtTel.Text + "','" + cboPassport.SelectedIndex + "','" + txtCardID.Text + "','" + txtCustoAdress.Text + "','" + dtpBirthday.Value + "','" + cboCustoType.SelectedIndex + "') ";
                MySqlConnection con = DBHelper.GetConnection();
                con.Open();
                int i = DBHelper.ExecuteNonQuery(sql);
                MessageBox.Show("添加成功");
                LoadCustomer();
                foreach (Control Ctrol in gbCustoInfo.Controls)
                {
                    if (Ctrol is TextBox)
                    {
                        Ctrol.Text = "";
                    }
                }
                picAddCusto.BackgroundImage = Resources.添_加a;
            }
            else
                MessageBox.Show("未正确的客户编号", "添加提示");
            picAddCusto.BackgroundImage = Resources.添_加a;
        }
        #endregion

        #region 搜索客户信息方法
        private void picSearch_Click(object sender, EventArgs e)
        {
            picSearch.BackgroundImage = Resources.搜索__1;
            List<Custo> c = new List<Custo>();
            picAddCusto.BackgroundImage = Resources.添_加a;
            picSearch.BackgroundImage = Resources.搜索__1a;
            if(txtCardID.Text!="")
            {
                Custo cto = DAL.CustoDao.SelectCustoInfoByCardId(txtCardID.Text);
                if (c!=null)
                {
                    c.Add(cto);
                    dgvCustomerList.DataSource = c;
                }
                else
                {
                    MessageBox.Show("用户不存在！", "提示");
                }
            }
            else
            {
                c = DAL.CustoDao.SelectCustoAll();
                dgvCustomerList.DataSource = c;
            }
            picSearch.BackgroundImage = Resources.搜索__1a;
        } 
        #endregion

        #region 计算点击次数
        private int n = 0; 
        #endregion

        #region 隐藏显示信息
        private void picShow_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                this.picShow.BackgroundImage = Resources.隐藏;
                n = 1;
                txtCardID.PasswordChar = Convert.ToChar("*");
            }
            else if (n == 1)
            {
                DialogResult ret = MessageBox.Show("证件号码为敏感信息，确定要进行查看吗？(此步操作将写入操作日志)", "信息提醒",MessageBoxButtons.YesNo);
                if (ret == DialogResult.Yes)
                {
                    this.picShow.BackgroundImage = Resources.显示;
                    n = 0;
                    txtCardID.PasswordChar = new char();
                    #region 获取添加操作日志所需的信息
                    OperationLog o = new OperationLog();
                    o.OperationTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd,HH:mm:ss"));
                    o.Operationlog = "于" + DateTime.Now + "查看了" + txtCustoName.Text + "的身份证号";
                    o.OperationAccount = "admin";
                    #endregion
                    BLL.OperationService.InsertOperationLog(o);
                }
                else
                {
                    MessageBox.Show("操作不成功！");
                }
                
            }
        }
        #endregion

        private void picGetCustoNo_Click(object sender, EventArgs e)
        {
            string cardId = BLL.CustoService.GetRandomCustoNo();
            txtCustoNo.Text = cardId;
            picGetCustoNo.BackgroundImage = Resources.获取用户编号_ia;
        }

        private void picGetCustoNo_MouseLeave(object sender, EventArgs e)
        {
            picGetCustoNo.BackgroundImage = Resources.获取用户编号;
        }

        private void txtCardID_Validated(object sender, EventArgs e)
        {

        }

        #region 修改客户信息方法
        private void picUpdateCusto_Click_1(object sender, EventArgs e)
        {
            picUpdateCusto.BackgroundImage = Resources.修改;
            if (txtCustoNo.Text != "")
            {
                string sql = "update userinfo set CustoName='" + txtCustoName.Text + "',CustoSex='" + cboSex.Text + "',CustoTel='" + txtTel.Text + "',PassportType='" + cboPassport.SelectedIndex + "',CustoID='" + txtCardID.Text + "',CustoAdress='" + txtCustoAdress.Text + "',CustoBirth='" + dtpBirthday.Value.ToShortTimeString() + "',CustoType='" + cboCustoType.SelectedIndex + "' where CustoNo='" + txtCustoNo.Text + "'";
                MySqlConnection con = DBHelper.GetConnection();
                con.Open();
                int i = DBHelper.ExecuteNonQuery(sql);
                MessageBox.Show("修改成功");
                LoadCustomer();
                foreach (Control Ctrol in gbCustoInfo.Controls)
                {
                    if (Ctrol is TextBox)
                    {
                        Ctrol.Text = "";
                    }
                }      
            }
            else
                MessageBox.Show("未正确的客户编号", "添加提示");
            picUpdateCusto.BackgroundImage = Resources.修改a;
        }
        #endregion
    }
}