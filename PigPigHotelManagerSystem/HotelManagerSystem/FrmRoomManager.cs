using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagerSystem.BLL;
using HotelManagerSystem.DAL;
using HotelManagerSystem.Model;
using HotelManagerSystem.Properties;
using System.Text.RegularExpressions;

namespace HotelManagerSystem
{
    public partial class FrmRoomManager : Form
    {
        public static string co_CustoNo;
        public static string co_RoomNo;
        public static string co_CustoName;
        public static string co_CheckTime;
        public static string co_Day;

        public FrmRoomManager()
        {
            InitializeComponent();

        }

        List<Room> romsty = null;
        ucRoomList romt = null;
        #region 房间加载事件方法
        private void FrmRoomManager_Load(object sender, EventArgs e)
        {
            romsty = RoomDao.SelectRoomAll();
            for (int i = 0; i < romsty.Count; i++)
            {
                romt = new ucRoomList(this);
                romt.Tag = romsty[i].RoomNo;
                romt.romCustoInfo = romsty[i];
                flpRoom.Controls.Add(romt);
            }

            lblCanUse.Text = RoomService.SelectCanUseRoomAllByRoomState().ToString();
            lblCheck.Text = RoomService.SelectNotUseRoomAllByRoomState().ToString();
            lblNotClear.Text = RoomService.SelectNotClearRoomAllByRoomState().ToString();
            lblFix.Text = RoomService.SelectFixingRoomAllByRoomState().ToString();
        }
        #endregion

        #region 遍历房间信息方法
        public void CmpInfo(Room rom, Custo user)
        {
            foreach (Control rmb in flpRoom.Controls)
            {
                if (rmb.Tag.ToString() != rom.RoomNo)
                {

                }

            }
        } 
        #endregion

        private void tmrGetData_Tick(object sender, EventArgs e)
        {
            lblRoomNo.Text = ucRoomList.co_RoomNo;
            lblCustoNo.Text = ucRoomList.co_CustoNo;
            lblRoomPosition.Text = ucRoomList.co_RoomPosition;
            if (ucRoomList.co_CheckTime == "0001-01-01 00:00:00")
            {
                lblCheckTime.Text = "";
            }
            else
            {
                lblCheckTime.Text = ucRoomList.co_CheckTime;
            }

            lblRoomState.Text = ucRoomList.co_RoomState;
            lblCustoNo.Text = ucRoomList.co_CustoNo;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            flpRoom.Controls.Clear();
            romsty = DAL.RoomDao.SelectRoomAll();
            for (int i = 0; i < romsty.Count; i++)
            {
                romt = new ucRoomList(this);
                romt.Tag = romsty[i].RoomNo;
                romt.romCustoInfo = romsty[i];
                flpRoom.Controls.Add(romt);
            }
        }

        private void btnBD_Click(object sender, EventArgs e)
        {
            LoadData(btnBD.Text);
        }

        private void LoadData(string typeName)
        {
            flpRoom.Controls.Clear();
            romsty = DAL.RoomDao.SelectRoomByTypeName(typeName);
            for (int i = 0; i < romsty.Count; i++)
            {
                romt = new ucRoomList(this);
                romt.Tag = romsty[i].RoomNo;
                romt.romCustoInfo = romsty[i];
                flpRoom.Controls.Add(romt);
            }
            lblCanUse.Text = BLL.RoomService.SelectCanUseRoomAllByRoomState().ToString();
            lblCheck.Text = BLL.RoomService.SelectNotUseRoomAllByRoomState().ToString();
            lblNotClear.Text = BLL.RoomService.SelectNotClearRoomAllByRoomState().ToString();
            lblFix.Text = BLL.RoomService.SelectFixingRoomAllByRoomState().ToString();
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            LoadData(btnBS.Text);
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            LoadData(btnHD.Text);
        }

        private void btnHS_Click(object sender, EventArgs e)
        {
            LoadData(btnHS.Text);
        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            LoadData(btnQL.Text);
        }

        private void btnZT_Click(object sender, EventArgs e)
        {
            LoadData(btnZT.Text);
        }

        private void picRefrech_Click(object sender, EventArgs e)
        {
            flpRoom.Controls.Clear();
            romsty = DAL.RoomDao.SelectRoomAll();
            for (int i = 0; i < romsty.Count; i++)
            {
                romt = new ucRoomList(this);
                romt.Tag = romsty[i].RoomNo;
                romt.romCustoInfo = romsty[i];
                flpRoom.Controls.Add(romt);
            }
            lblRoomNo.Text = "";
            lblRoomPosition.Text = "";
            lblRoomState.Text = "";
            lblCustoNo.Text = "";
            lblCheckTime.Text = "";    
        }
    }
}