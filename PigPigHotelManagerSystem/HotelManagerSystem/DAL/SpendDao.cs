using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagerSystem.Model;

namespace HotelManagerSystem.DAL
{
    public class SpendDao
    {
        #region 添加消费信息
        /// <summary>
        /// 添加消费信息
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int InsertSpendInfo(Spend s)
        {
            int n = 0;
            string sql = "insert into spend(RoomNo,CustoNo,RoomName,SpendPrice,SpendMoney,SpendTime,MoneyState) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
            sql = string.Format(sql, s.RoomNo, s.CustoNo, s.RoomName, s.SpendPrice, s.SpendMoney, s.SpendTime, s.MoneyState);
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 根据客户编号查询信息
        /// <summary>
        /// 根据客户编号查询信息
        /// </summary>
        /// <param name="CustoNo"></param>
        /// <param name="RoomNo"></param>
        /// <returns></returns>
        public static List<Spend> SelectSpendByRoomNo(string RoomNo)
        {
            List<Spend> spends = new List<Spend>();
            string sql = "select * from SPEND c,ROOM r where c.RoomNo=r.RoomNo";
            sql += " and c.RoomNo = '" + RoomNo + "' and SpendTime between r.CheckTime AND GETDATE()";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Spend spend = new Spend();
                spend.RoomNo = dr["RoomNo"].ToString();
                spend.CustoNo = dr["CustoNo"].ToString();
                spend.SpendPrice = Convert.ToDecimal(dr["SpendPrice"]);
                spend.SpendMoney = Convert.ToDecimal(dr["SpendMoney"]);
                spend.SpendTime = Convert.ToDateTime(dr["SpendTime"]);
                spends.Add(spend);
            }
            dr.Close();
            DBHelper.Closecon();
            return spends;
        }
        #endregion

        #region 根据客户编号查询消费信息
        /// <summary>
        /// 根据客户编号查询消费信息
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        public static List<Spend> SelectSpendByCustoNo(string No)
        {
            List<Spend> ls = new List<Spend>();
            string sql = "select * from SPEND where CustoNo like '%" + No + "%' or RoomNo like '%" + No + "%'";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Spend s = new Spend();
                s.RoomNo = dr["RoomNo"].ToString();
                s.CustoNo = dr["CustoNo"].ToString();
                s.SpendPrice = Convert.ToDecimal(dr["SpendPrice"]);
                s.SpendMoney = Convert.ToDecimal(dr["SpendMoney"]);
                s.SpendTime = Convert.ToDateTime(dr["SpendTime"]);
                s.MoneyState = dr["MoneyState"].ToString();
                ls.Add(s);
            }
            dr.Close();
            DBHelper.Closecon();
            return ls;
        }
        #endregion

        #region 查询消费的所有信息
        /// <summary>
        /// 查询消费的所有信息
        /// </summary>
        /// <returns></returns>
        public static List<Spend> SelectSpendInfoAll()
        {
            List<Spend> ls = new List<Spend>();
            string sql = "select * from spend";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Spend s = new Spend();
                s.RoomNo = (string)dr["RoomNo"];
                s.CustoNo = (string)dr["CustoNo"];
                s.SpendPrice = (decimal)dr["SpendPrice"];
                s.SpendMoney = (decimal)dr["SpendMoney"];
                s.SpendTime = (DateTime)dr["SpendTime"];
                s.MoneyState = dr["MoneyState"].ToString();
                ls.Add(s);
            }
            dr.Close();
            DBHelper.Closecon();
            return ls;
        }
        #endregion

        #region 根据房间号查询消费的所有信息
        /// <summary>
        /// 根据房间号查询消费的所有信息
        /// </summary>
        /// <returns></returns>
        public static List<Spend> SelectSpendInfoRoomNo(string RoomNo)
        {
            List<Spend> ls = new List<Spend>();
            string sql = "select * from SPEND c,ROOM r,RoomState rs where c.RoomNo=r.RoomNo and r.RoomNo=rs.RoomStateId and c.RoomNo = '" + RoomNo + "' and SpendTime between r.CheckTime AND NOW()";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Spend s = new Spend();
                s.RoomNo = dr["RoomNo"].ToString();
                s.CustoNo = dr["CustoNo"].ToString();
                s.RoomName = dr["RoomName"].ToString();
                s.SpendPrice = Convert.ToDecimal(dr["SpendPrice"]);
                s.SpendMoney = Convert.ToDecimal(dr["SpendMoney"]);
                s.SpendTime = Convert.ToDateTime(dr["SpendTime"]);
                s.MoneyState = dr["MoneyState"].ToString();
                ls.Add(s);
            }
            dr.Close();
            DBHelper.Closecon();
            return ls;
        }
        #endregion

        #region 根据房间编号、入住时间到当前时间查询消费总金额
        /// <summary>
        /// 根据房间编号、入住时间到当前时间查询消费总金额
        /// </summary>
        /// <param name="roomno"></param>
        /// <returns></returns>
        public static object SelectMoneyByRoomNoAndTime(string roomno)
        {
            string sql = "select SpendMoney from SPEND c,ROOM r where c.RoomNo=r.RoomNo ";
            sql += "and c.RoomNo = '" + roomno + "' and SpendTime between r.CheckTime AND NOW()";
            return DBHelper.ExecuteScalar(sql);
        }
        #endregion

        #region 根据房间编号、入住时间和当前时间修改结算状态
        /// <summary>
        /// 根据房间编号、入住时间和当前时间修改结算状态
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="checktime"></param>
        /// <returns></returns>
        public static int UpdateMoneyState(string roomno, string checktime)
        {
            string sql = "update SPEND set MoneyState='已结算' where RoomNo='{0}' and SpendTime between '{1}' AND NOW()";
            sql = string.Format(sql, roomno, checktime);
            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion

        #region 查询消费记录
        /// <summary>
        /// 查询消费的所有信息
        /// </summary>
        /// <returns></returns>
        public static List<SpendLog> SelectSpendOperation()
        {
            List<SpendLog> ls = new List<SpendLog>();
            string sql = "select SpendId,RoomNo,CustoNo,SpendMoney,SpendTime,MoneyState from spend";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {                        
                if (dr["MoneyState"].ToString() != "未结算")
                {
                    SpendLog s = new SpendLog();
                    s.SpendId= (int)dr["SpendId"];
                    s.RoomNo = (string)dr["RoomNo"];
                    s.CustoNo = (string)dr["CustoNo"];
                    s.SpendMoney = (decimal)dr["SpendMoney"];
                    s.SpendTime = (DateTime)dr["SpendTime"];
                    ls.Add(s);
                }
            }
            dr.Close();
            DBHelper.Closecon();
            return ls;
        }
        #endregion
    }
}
