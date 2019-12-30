using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagerSystem.DAL;
using HotelManagerSystem.Model;

namespace HotelManagerSystem.BLL
{
   public class SpendService
    {
        public static int InsertSpendInfo(Spend s)
        {
            return SpendDao.InsertSpendInfo(s);
        }

        public static List<Spend> SelectSpendByCustoNo(string No)
        {
            return SpendDao.SelectSpendByCustoNo(No);
        }

        public static List<Spend> SelectSpendInfoAll()
        {
            return SpendDao.SelectSpendInfoAll();
        }

        /// <summary>
        /// 根据房间号查询消费的所有信息
        /// </summary>
        /// <returns></returns>
        public static List<Spend> SelectSpendInfoRoomNo(string RoomNo)
        {
            return SpendDao.SelectSpendInfoRoomNo(RoomNo);
        }

        #region 根据房间编号、入住时间到当前时间查询消费总金额
        /// <summary>
        /// 根据房间编号、入住时间到当前时间查询消费总金额
        /// </summary>
        /// <param name="roomno"></param>
        /// <returns></returns>
        public static object SelectMoneyByRoomNoAndTime(string roomno)
        {
            return SpendDao.SelectMoneyByRoomNoAndTime(roomno);
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
            return SpendDao.UpdateMoneyState(roomno, checktime);
        }
        #endregion

    }
}
