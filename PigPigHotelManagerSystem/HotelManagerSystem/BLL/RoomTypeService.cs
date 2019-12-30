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
   public class RoomTypeService
    {
        #region 获取所有房间类型
        /// <summary>
        /// 获取所有房间类型
        /// </summary>
        /// <returns></returns>
        public static List<RoomType> SelectRoomTypesAll()
        {
            return RoomTypeDao.SelectRoomTypesAll();
        }
        #endregion

        #region 根据房间编号查询房间类型名称
        /// <summary>
        /// 根据房间编号查询房间类型名称
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public static RoomType SelectRoomTypeByRoomNo(string no)
        {
            return RoomTypeDao.SelectRoomTypeByRoomNo(no);
        }
        #endregion
    }
}
